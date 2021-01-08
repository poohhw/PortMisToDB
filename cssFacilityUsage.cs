using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PortMisDataToDB
{
    public class cssFacilityUsage
    {
        private Dictionary<string, string> dicFacilityUsageStaus = new Dictionary<string, string>()
        {
            {"rnum","순번" },
            {"clsgn","호출부호"},
            {"etryptYear","입항횟수(연도)"},
            {"etryptCo","입항횟수(횟수)"},
            {"fcltyUseCo","시설사용횟수"},
            {"realTn","신고톤수"},
            {"vsslNm","선박명"},
            {"satmntEntrpsCd","선사/대리점(코드)"},
            {"satmntEntrpsNm","선사/대리점(이름)"},
            {"reqstFcltyCd","신청시설(코드)"},
            {"reqstFcltySubCd","신청시설(번호)"},
            {"reqstFcltyNm","신청시설(이름)"},
            {"beginPrrrnDt","신청일시(FROM)"},
            {"endPrrrnDt","신청일시(TO)"},
            {"useFcltyCd","지정시설(코드)"},
            {"useFcltySubCd","지정시설(번호)"},
            {"useFcltyNm","지정시설(이름)"},
            {"beginAppnDt","지정일시(FROM)"},
            {"endAppnDt","지정일시(TO)"},
            {"usePurpsNm","사용목적명"},
            {"frcstDt","예보일시"},
            {"prmisnYn","허가유무"}

        };
        //public string rnum { get; set; }                                   //            순번                                                             
        public string clsgn { get; set; }                                   //             호출부호                                                            
        public string etryptYear { get; set; }                                   //                  입항횟수(연도)                                                            
        public string etryptCo { get; set; }                                   //                입항횟수(횟수)                                                            
        public string fcltyUseCo { get; set; }                                   //                  시설사용횟수                                                            
        public string realTn { get; set; }                                   //              신고톤수                                                            
        public string vsslNm { get; set; }                                   //              선박명                                                            
        public string satmntEntrpsCd { get; set; }                                   //                      선사/대리점(코드)                                                            
        public string satmntEntrpsNm { get; set; }                                   //                      선사/대리점(이름)                                                            
        public string reqstFcltyCd { get; set; }                                   //                    신청시설(코드)                                                            
        public string reqstFcltySubCd { get; set; }                                   //                       신청시설(번호)                                                            
        public string reqstFcltyNm { get; set; }                                   //                    신청시설(이름)                                                            
        public string beginPrrrnDt { get; set; }                                   //                    신청일시(FROM)                                                            
        public string endPrrrnDt { get; set; }                                   //                  신청일시(TO)                                                            
        public string useFcltyCd { get; set; }                                   //                  지정시설(코드)                                                            
        public string useFcltySubCd { get; set; }                                   //                     지정시설(번호)                                                            
        public string useFcltyNm { get; set; }                                   //                  지정시설(이름)                                                            
        public string beginAppnDt { get; set; }                                   //                   지정일시(FROM)                                                            
        public string endAppnDt { get; set; }                                   //                 지정일시(TO)                                                            
        public string usePurpsNm { get; set; }                                   //                  사용목적명                                                            
        public string frcstDt { get; set; }                                   //               예보일시                                                            
        public string prmisnYn { get; set; }                                   //                허가유무                                        

        public List<cssFacilityUsage> DataTableToClass(DataTable dt)
        {
            List<cssFacilityUsage> lstData = new List<cssFacilityUsage>();

            if (dt == null) return lstData;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cssFacilityUsage vio = new cssFacilityUsage();
                PropertyInfo[] props = vio.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

                foreach (var property in props)
                {
                    string colName = string.Empty;
                    if (dicFacilityUsageStaus.TryGetValue(property.Name, out colName))
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
