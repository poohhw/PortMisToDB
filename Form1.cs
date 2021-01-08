using NotVisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlBulkTools;
using System.Transactions;
using System.Configuration;
using System.IO;

namespace PortMisDataToDB
{
  
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=155.155.4.93;Initial Catalog=Portmis;User ID=sa;Password=gcsc8932";
        private string[] arrFolder = new string[] {"SI","FU","PIO","DC","VHF","VHF_DETAIL"};
        private List<FileInfo[]> fileList = new List<FileInfo[]>();
        private string sRootPath;
        public Form1()
        {
            InitializeComponent();
            sRootPath = ConfigurationManager.AppSettings["RootPath"];
            lbl_RootFolder.Text = sRootPath;
            ShowFile(sRootPath);

        }

        private void ShowFile(string RootPath)
        {
            fileList.Clear();


            foreach (string folder in arrFolder)
            {
                DirectoryInfo dirFI = new DirectoryInfo(Path.Combine(RootPath, folder));

                if (Directory.Exists(dirFI.FullName))
                {
                    FileInfo[] files = dirFI.GetFiles();

                    //FileInfo[] files = file_SI.AsEnumerable().Where(x => !x.Name.StartsWith("#")).ToArray();

                    fileList.Add(files);
                }
                else
                {
                    FileInfo[] files = { };
                    fileList.Add(files);
                }
            }

            lbx_SI.DataSource = fileList[0];
            lbx_SI.ValueMember = "FullName";
            lbx_SI.DisplayMember = "Name";
            lblFLCount.Text = fileList[0].Count().ToString() + " 건";

            lbx_FU.DataSource = fileList[1];
            lbx_FU.ValueMember = "FullName";
            lbx_FU.DisplayMember = "Name";
            lblFUCount.Text = fileList[1].Count().ToString() + " 건";

            lbx_PIO.DataSource = fileList[2];
            lbx_PIO.ValueMember = "FullName";
            lbx_PIO.DisplayMember = "Name";
            lblFIOCount.Text = fileList[2].Count().ToString() + " 건";

            lbx_DC.DataSource = fileList[3];
            lbx_DC.ValueMember = "FullName";
            lbx_DC.DisplayMember = "Name";
            lblDCCount.Text = fileList[3].Count().ToString() + " 건";

            lbx_VHF.DataSource = fileList[4];
            lbx_VHF.ValueMember = "FullName";
            lbx_VHF.DisplayMember = "Name";
            lblVHFCount.Text = fileList[4].Count().ToString() + " 건";

            lbx_VHF_DETAIL.DataSource = fileList[5];
            lbx_VHF_DETAIL.ValueMember = "FullName";
            lbx_VHF_DETAIL.DisplayMember = "Name";
            lblVHFDetailCount.Text = fileList[5].Count().ToString() + " 건";
        }

        public void Save()
        {
            //1.선박 제원정보
            foreach (FileInfo item in lbx_SI.Items)
            {
                DataTable VesselInfor_DT = GetDataTabletFromCSVFile(item.FullName);
                CopyToDataBaseFromVesselInfomation(VesselInfor_DT);
                MoveFile(item);
            }
            txtLog.AppendText($"선박 제원 정보 파일 {lbx_SI.Items.Count} 건 DB 동기화 완료{Environment.NewLine}");
            

            //2.선박 입출항 정보
            foreach (FileInfo item in lbx_PIO.Items)
            {
                DataTable VesselInOut_DT = GetDataTabletFromCSVFile(item.FullName);
                CopyToDataBaseFromVesselInOut(VesselInOut_DT);
                MoveFile(item);
            }

            txtLog.AppendText($"선박 입출항 정보 파일 {lbx_PIO.Items.Count} 건 DB 동기화 완료{Environment.NewLine}");

            //3.시설물 사용 현황 정보
            foreach (FileInfo item in lbx_FU.Items)
            {
                DataTable FacilityUsage_DT = GetDataTabletFromCSVFile(item.FullName);
                CopyToDataBaseFromFacilityUsage(FacilityUsage_DT);
                MoveFile(item);
            }
            txtLog.AppendText($"시설물 사용 현황 정보 파일  {lbx_FU.Items.Count} 건 DB 동기화 완료{Environment.NewLine}");

            //4.위험물 반입 신고 현황
            foreach (FileInfo item in lbx_DC.Items)
            {
                DataTable DangerousDetail_DT = GetDataTabletFromCSVFile(item.FullName);
                CopyToDataBaseFromDangerousDetail(DangerousDetail_DT);
                MoveFile(item);
            }
            txtLog.AppendText($"위험물 반입 신고 현황 파일  {lbx_DC.Items.Count} 건 DB 동기화 완료{Environment.NewLine}");

            //5.관제 교신 현황
            foreach (FileInfo item in lbx_VHF.Items)
            {
                DataTable ControlCommunicationStauts_DT = GetDataTabletFromCSVFile(item.FullName);
                CopyToDataBaseFromControlCommuStatus(ControlCommunicationStauts_DT);
                MoveFile(item);
            }
            txtLog.AppendText($"관제 교신 현황 파일 {lbx_VHF.Items.Count} 건 DB 동기화 완료{Environment.NewLine}");

            //5.관제 교신 상세 현황
            foreach (FileInfo item in lbx_VHF_DETAIL.Items)
            {
                DataTable ControlCommunicationDetail_DT = GetDataTabletFromCSVFile(item.FullName);
                CopyToDataBaseFromControlCommuDetail(ControlCommunicationDetail_DT);
                MoveFile(item);
            }
            txtLog.AppendText($"관제 교신 상세 현황 파일 {lbx_VHF_DETAIL.Items.Count} 건 DB 동기화 완료{Environment.NewLine}");

            MessageBox.Show("저장 완료");

            ShowFile(sRootPath);
        }

        private static void MoveFile(FileInfo item)
        {
            if (!Directory.Exists(Path.Combine(item.DirectoryName, "DB")))
            {
                Directory.CreateDirectory(Path.Combine(item.DirectoryName, "DB"));
            }
            item.MoveTo(Path.Combine(item.DirectoryName, "DB", item.Name));
        }

        private static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                using (CsvTextFieldParser csvReader = new CsvTextFieldParser(csv_file_path,Encoding.Default))
                {
                    csvReader.Delimiters = new string[] { "," };
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return csvData;
        }

        /// <summary>
        /// 선박 제원정보 저장
        /// </summary>
        /// <param name="csvFileData"></param>
        private void CopyToDataBaseFromVesselInfomation(DataTable csvFileData)
        {

            cssVesselInfo vi = new cssVesselInfo();
            List<cssVesselInfo> lstData = vi.DataTableToClass(csvFileData);

            var bulk = new BulkOperations();
           // var VesselInfo = new List<VesselInfo>();

            using (TransactionScope trans = new TransactionScope())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    bulk.Setup<cssVesselInfo>()
                           .ForCollection(lstData)
                           .WithTable("VesselInfo")
                           .AddAllColumns()
                           .BulkInsertOrUpdate()
                           //.SetIdentityColumn(x => x.clsgn)
                           .MatchTargetOn(x => x.clsgn)
                           .Commit(conn);
                }

                trans.Complete();
            }
        }

        /// <summary>
        /// 선박 입출항 정보 저장
        /// </summary>
        /// <param name="csvFileData"></param>
        private void CopyToDataBaseFromVesselInOut(DataTable csvFileData)
        {

            cssVesselInOut vio = new cssVesselInOut();
            List<cssVesselInOut> lstData = vio.DataTableToClass(csvFileData);

            var bulk = new BulkOperations();
            // var VesselInfo = new List<VesselInfo>();

            using (TransactionScope trans = new TransactionScope())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    bulk.Setup<cssVesselInOut>()
                           .ForCollection(lstData)
                           .WithTable("VesselInOut")
                           .AddAllColumns()
                           .BulkInsertOrUpdate()
                           //.SetIdentityColumn(x => x.clsgn)
                           .MatchTargetOn(x => x.clsgn)
                           .MatchTargetOn(x => x.etryptYear)
                           .MatchTargetOn(x => x.etryptCo)
                           .MatchTargetOn(x => x.etryndNm)
                           .MatchTargetOn(x => x.prtAgNm)
                           .Commit(conn);
                }

                trans.Complete();
            }
        }
        /// <summary>
        /// 시설물 사용현황 저장
        /// </summary>
        /// <param name="csvFileData"></param>
        private void CopyToDataBaseFromFacilityUsage(DataTable csvFileData)
        {

            cssFacilityUsage vio = new cssFacilityUsage();
            List<cssFacilityUsage> lstData = vio.DataTableToClass(csvFileData);

            var bulk = new BulkOperations();
            // var VesselInfo = new List<VesselInfo>();

            using (TransactionScope trans = new TransactionScope())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    bulk.Setup<cssFacilityUsage>()
                           .ForCollection(lstData)
                           .WithTable("FacilityUsage")
                           .AddAllColumns()
                           .BulkInsertOrUpdate()
                           //.SetIdentityColumn(x => x.clsgn)
                           .MatchTargetOn(x => x.clsgn)
                           .MatchTargetOn(x => x.etryptYear)
                           .MatchTargetOn(x => x.etryptCo)
                           .MatchTargetOn(x => x.fcltyUseCo)
                           .Commit(conn);
                }

                trans.Complete();
            }
        }

        /// <summary>
        /// 위험물 반입신고 저장.
        /// </summary>
        /// <param name="csvFileData"></param>
        private void CopyToDataBaseFromDangerousDetail(DataTable csvFileData)
        {

            cssDangerousDetail vio = new cssDangerousDetail();
            List<cssDangerousDetail> lstData = vio.DataTableToClass(csvFileData);

            var bulk = new BulkOperations();
            // var VesselInfo = new List<VesselInfo>();

            using (TransactionScope trans = new TransactionScope())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    bulk.Setup<cssDangerousDetail>()
                           .ForCollection(lstData)
                           .WithTable("DangerousDetail")
                           .AddAllColumns()
                           .BulkInsertOrUpdate()
                           .MatchTargetOn(x => x.prtAgCd)
                           .MatchTargetOn(x => x.clsgn)
                           .MatchTargetOn(x => x.tkinSe)
                           .MatchTargetOn(x => x.etryptYear)
                           .MatchTargetOn(x => x.etryptCo)                          
                           
                           .Commit(conn);
                }

                trans.Complete();
            }
        }

        /// <summary>
        /// 관제 교신 현황 저장
        /// </summary>
        /// <param name="csvFileData"></param>
        private void CopyToDataBaseFromControlCommuStatus(DataTable csvFileData)
        {

            cssControlCommunicationStauts vio = new cssControlCommunicationStauts();
            List<cssControlCommunicationStauts> lstData = vio.DataTableToClass(csvFileData);

            var bulk = new BulkOperations();
            // var VesselInfo = new List<VesselInfo>();

            using (TransactionScope trans = new TransactionScope())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    bulk.Setup<cssControlCommunicationStauts>()
                           .ForCollection(lstData)
                           .WithTable("ControlCommunication")
                           .AddAllColumns()
                           .BulkInsertOrUpdate()
                           .MatchTargetOn(x => x.clsgn)
                           .MatchTargetOn(x => x.etryptYear)
                           .MatchTargetOn(x => x.etryptCo)

                           .Commit(conn);
                }

                trans.Complete();
            }
        }

        private void CopyToDataBaseFromControlCommuDetail(DataTable csvFileData)
        {

            cssControlCommunicationDetail vio = new cssControlCommunicationDetail();
            List<cssControlCommunicationDetail> lstData = vio.DataTableToClass(csvFileData);

            var bulk = new BulkOperations();
            // var VesselInfo = new List<VesselInfo>();

            using (TransactionScope trans = new TransactionScope())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    bulk.Setup<cssControlCommunicationDetail>()
                           .ForCollection(lstData)
                           .WithTable("ControlCommunicationDetail")
                           .AddAllColumns()
                           .BulkInsertOrUpdate()
                           .MatchTargetOn(x => x.commCo)
                           .MatchTargetOn(x => x.clsgn)
                           .MatchTargetOn(x => x.cntrlSe)
                           .MatchTargetOn(x => x.cntrlNm)
                           .MatchTargetOn(x => x.cntrlOpertDt)

                           .Commit(conn);
                }

                trans.Complete();
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                lbl_RootFolder.Text = folderBrowserDialog1.SelectedPath;

                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings["RootPath"] == null)
                {
                    settings.Add("RootPath", folderBrowserDialog1.SelectedPath);
                }
                else
                {
                    settings["RootPath"].Value = folderBrowserDialog1.SelectedPath;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                ShowFile(folderBrowserDialog1.SelectedPath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }
    }

   
}


