using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PortMisDataToDB
{
    public class cssControlCommunicationDetail
    {
        private Dictionary<string, string> ControlCommunicationDetail = new Dictionary<string, string>()
        {
            {"idx" , "교신현황 순번" },
            {"commCo","순번"},
            {"prtAgNm","항명" },
            {"clsgn","호출부호"},
            {"cntrlSe","구분(코드)"},
            {"cntrlNm","구분(이름)"},
            {"fcltyCd","교신시설(코드)"},
            {"fcltySubCd","교신시설(번호)"},
            {"fcltyNm","교신시설(이름)"},
            {"cntrlOpertDt","교신시각"},
            {"artcntId","교신자"},
            {"piltId1","도선사"},
            {"bargeClsgn1","부선1(코드)"},
            {"bargeClsgnNm1","부선1(이름)"},
            {"bargeClsgn2","부선2(코드)"},
            {"bargeClsgnNm2","부선2(이름)"},
        };
        //public string idx { get; set; }//교신현황순번
        public string commCo { get; set; }//순번
        public string prtAgNm { get; set; }//순번
        public string clsgn { get; set; }//호출부호
        public string cntrlSe { get; set; }//구분(코드)
        public string cntrlNm { get; set; }//구분(이름)
        public string fcltyCd { get; set; }//교신시설(코드)
        public string fcltySubCd { get; set; }//교신시설(번호)
        public string fcltyNm { get; set; }//교신시설(이름)
        public string cntrlOpertDt { get; set; }//교신시각
        public string artcntId { get; set; }//교신자
        public string piltId1 { get; set; }//도선사
        public string bargeClsgn1 { get; set; }//부선1(코드)
        public string bargeClsgnNm1 { get; set; }//부선1(이름)
        public string bargeClsgn2 { get; set; }//부선2(코드)
        public string bargeClsgnNm2 { get; set; }//부선2(이름)

        public List<cssControlCommunicationDetail> DataTableToClass(DataTable dt)
        {
            List<cssControlCommunicationDetail> lstData = new List<cssControlCommunicationDetail>();

            if (dt == null) return lstData;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cssControlCommunicationDetail vio = new cssControlCommunicationDetail();
                PropertyInfo[] props = vio.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

                foreach (var property in props)
                {
                    string colName = string.Empty;
                    if (ControlCommunicationDetail.TryGetValue(property.Name, out colName))
                    {
                        property.SetValue(vio, dt.Rows[i][colName].ToString());
                    }
                }

                lstData.Add(vio);

            }


            return lstData;
        }
    }
}
