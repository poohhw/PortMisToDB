using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PortMisDataToDB
{

    public class cssControlCommunicationStauts
    {
        private Dictionary<string, string> ControlCommunicationStauts = new Dictionary<string, string>()
        {
            {"rnum","순번" },
            {"prtAgNm","항명" },
            {"clsgn","호출부호"},
            {"etryptYear","입항횟수(연도)"},
            {"etryptCo","입항횟수(횟수)"},
            {"vsslKorNm","선박명"},
            {"aprtfEtryptDt","입항일자"},
            {"tkoffDt","출항일자"},
            {"satmntEntrpsCd","업체코드"},
            {"satmntEntrpsNm","선사/대리점"},
            {"vsslNltyCd","국적(코드)"},
            {"vsslNltyNm","국적(이름)"},
            {"cntrlSeList","관제상태"},
            {"bargeClsgn1","부선1(코드)"},
            {"bargeClsgnNm1","부선1(이름)"},
            {"bargeClsgn2","부선2(코드)"},
            {"bargeClsgnNm2","부선2(이름)"},
            {"grtg","총톤수"},
            {"intrlGrtg","국제톤수"},
            {"vsslTotLt","총길이"},
            {"shdth","너비"},
            {"vsslDp","깊이"},
            {"vsslDrft","흘수"},
            {"rm","특이사항"},
            {"vsslTelno1","전화번호(선박)"},
            {"vsslTelno2","전화번호(업체)"},
            {"vsslTelno3","전화번호(선장)"},
            {"telnoRm","전화번호비고"},
        };
        //public string rnum { get; set; }//순번
         public string prtAgNm { get; set; }//항명
        public string clsgn { get; set; }//호출부호
        public string etryptYear { get; set; }//입항횟수(연도)
        public string etryptCo { get; set; }//입항횟수(횟수)  
        public string vsslKorNm { get; set; }//선박명                          
        public string aprtfEtryptDt { get; set; }//입항일자                          
        public string tkoffDt { get; set; }//출항일자
        public string satmntEntrpsCd { get; set; }//업체코드                            
        public string satmntEntrpsNm { get; set; }//선사/대리점 
        public string vsslNltyCd { get; set; }//국적(코드)                                
        public string vsslNltyNm { get; set; }//국적(이름)                                
        public string cntrlSeList { get; set; }//관제상태                                          
        public string bargeClsgn1 { get; set; }//부선1(코드)               
        public string bargeClsgnNm1 { get; set; }//부선1(이름)
        public string bargeClsgn2 { get; set; }//부선2(코드)               
        public string bargeClsgnNm2 { get; set; }//부선2(이름)
        public string grtg { get; set; }//총톤수
        public string intrlGrtg { get; set; }//국제톤수                            
        public string vsslTotLt { get; set; }//총길이                          
        public string shdth { get; set; }//너비
        public string vsslDp { get; set; }//깊이
        public string vsslDrft { get; set; }//흘수  
        public string rm { get; set; }//특이사항
        public string vsslTelno1 { get; set; }//전화번호(선박)
        public string vsslTelno2 { get; set; }//전화번호(업체)
        public string vsslTelno3 { get; set; }//전화번호(선장)
        public string telnoRm { get; set; }//전화번호(비고)

        public List<cssControlCommunicationStauts> DataTableToClass(DataTable dt)
        {
            List<cssControlCommunicationStauts> lstData = new List<cssControlCommunicationStauts>();

            if (dt == null) return lstData;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cssControlCommunicationStauts vio = new cssControlCommunicationStauts();
                PropertyInfo[] props = vio.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

                foreach (var property in props)
                {
                    string colName = string.Empty;
                    if (ControlCommunicationStauts.TryGetValue(property.Name, out colName))
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
