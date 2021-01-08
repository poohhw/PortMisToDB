using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PortMisDataToDB
{
    public class cssVesselInOut
    {
        private Dictionary<string, string> dicInOut = new Dictionary<string, string>()
        {
            {"rnum","순번"},
            {"prtAgNm","항명"},
            {"clsgn","호출부호"},
            {"vsslNm","선명"},
            {"etryptYear","입항횟수(연도)"},
            {"etryptCo","입항횟수(횟수)"},
            {"reqstSeNm","구분"},
            {"ibobprtSeNm","외내"},
            {"etryndNm","입출"},
            {"grtg","총톤수"},
            {"intrlGrtg","국제톤수"},
            {"revTn","징수톤수"},
            {"etryptDt","입항일시"},
            {"tkoffDt","출항일시"},
            {"ciqPrcsDt","CIO수속일자"},
            {"prmisnDt","수리일시"},
            {"voyageSeNm","항해구분"},
            {"mrnum","MRN번호"},
            {"vsslNltyCd","국적(코드)"},
            {"vsslNltyNm","국적(이름)"},
            {"laidupFcltyCd","계선장소(코드)"},
            {"laidupFcltySubCd","계선장소(번호)"},
            {"laidupFcltyNm","계선장소(이름)"},
            {"nxlnptPrtNm","차항지"},
            {"prvsDpmprtPrtNm","전출항지"},
            {"vsslKindNm","선박용도"},
            {"koranCrewCo","승무원1"},
            {"frgnrCrewCo","승무원2"},
            {"allPsngerCo","승객"},
            {"tugYn","예선"},
            {"piltgYn","도선"},
            {"bargeClsgn1","부선호출부호1"},
            {"bargeClsgn2","부선호출부호2"}
        };
       // public string rnum { get; set; }          //      순번                               
        public string prtAgNm { get; set; }          //         항명                               
        public string clsgn { get; set; }          //       호출부호                               
        public string vsslNm { get; set; }          //        선명                               
        public string etryptYear { get; set; }          //            입항횟수(연도)                               
        public string etryptCo { get; set; }          //          입항횟수(횟수)                               
        public string reqstSeNm { get; set; }          //           구분                               
        public string ibobprtSeNm { get; set; }          //             외내                               
        public string etryndNm { get; set; }          //          입출                               
        public string grtg { get; set; }          //      총톤수                               
        public string intrlGrtg { get; set; }          //           국제톤수                               
        public string revTn { get; set; }          //       징수톤수                               
        public string etryptDt { get; set; }          //          입항일시                               
        public string tkoffDt { get; set; }          //         출항일시                               
        public string ciqPrcsDt { get; set; }          //           CIO수속일자                               
        public string prmisnDt { get; set; }          //          수리일시                               
        public string voyageSeNm { get; set; }          //            항해구분                               
        public string mrnum { get; set; }          //       MRN 번호                               
        public string vsslNltyCd { get; set; }          //            국적(코드)                               
        public string vsslNltyNm { get; set; }          //            국적(이름)                               
        public string laidupFcltyCd { get; set; }          //               계선장소코드                               
        public string laidupFcltySubCd { get; set; }          //                  계선장소번호                               
        public string laidupFcltyNm { get; set; }          //               계선장소이름                               
        public string nxlnptPrtNm { get; set; }          //             차항지                               
        public string prvsDpmprtPrtNm { get; set; }          //                 전출항지                               
        public string vsslKindNm { get; set; }          //            선박용도                               
        public string koranCrewCo { get; set; }          //             승무원1                               
        public string frgnrCrewCo { get; set; }          //             승무원2                               
        public string allPsngerCo { get; set; }          //             승객                               
        public string tugYn { get; set; }          //       예선                               
        public string piltgYn { get; set; }          //         도선                               
        public string bargeClsgn1 { get; set; }          //             부선호츌부호1                               
        public string bargeClsgn2 { get; set; }          //             부선호출부호2

        public List<cssVesselInOut> DataTableToClass(DataTable dt)
        {
            List<cssVesselInOut> lstData = new List<cssVesselInOut>();

            if (dt == null) return lstData;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cssVesselInOut vio = new cssVesselInOut();
                PropertyInfo[] props = vio.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

                foreach (var property in props)
                {
                    string colName = string.Empty;
                    if (dicInOut.TryGetValue(property.Name, out colName))
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
