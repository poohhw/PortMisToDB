using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PortMisDataToDB
{
    public class cssVesselInfo
    {
        private Dictionary<string, string> VesselDetailInfo = new Dictionary<string, string>()
        {
            {"clsgn","호출부호"},
            {"befClsgn","전호출부호"},
            {"vsslNo","선박번호"},
            {"imoNo","IMO 번호"},
            {"mmsiNo","MMSI 번호"},
            {"vsslKorNm","선박명(한글)"},
            {"vsslEngNm","선박명(영문)"},
            {"vsslNltyCd","선박국적(코드)"},
            {"vsslNltyNm","선박국적(이름)"},
            {"shipngNatCd","선적항(국적코드)"},
            {"shipngPrtCd","선적항(항코드)"},
            {"shipngPrtNm","선적항(이름)"},
            {"vsslKndNm","선박종류"},
            {"grtg","총톤수"},
            {"ntng","순톤수"},
            {"intrlGrtg","국제총톤수"},
            {"cmdtyWtTon","재화중량톤수"},
            {"vsslTotLt","선박제원(총길이)"},
            {"shdth","선박제원(너비)"},
            {"vsslDrft","만재흘수"},
            {"vsslDp","깊이"},
            {"vsslLt","길이1"},
            {"vsslCnstrDt","건조일"},
            {"shpwnrNltyCd","선주국적(코드)"},
            {"shpwnrNltyNm","선주국적(이름)"},
            {"shpwnrEntrpsCd","선주업체(코드)"},
            {"shpwnrEntrpsNm","선주업체(이름)"},
            {"oprtrNltyCd","운영자국적(코드)"},
            {"oprtrNltyNm","운영자국적(이름)"},
            {"oprtrEntrpsCd","운영자업체(코드)"},
            {"oprtrEntrpsNm","운영자업체(이름)"},
            {"satmntEntrpsCd","선사/대리점(코드)"},
            {"satmntEntrpsNm","선사/대리점(이름)"},
            {"nvgShapCd","운항형태"},
            {"ibobprtSe","외내항구분"},
            {"brbtSe","나용구분"},
            {"okrDplcHullAt","유조선이중선체여부"},
            {"sbtYn","SBT구조여부"},
            {"lastInspctKndNm","최종검사정보"},
            {"lastInspctDt","최종검사일"},
            {"nxttrmInspctKndNm","차기검사종류"},
            {"nxttrmInspctDt","차기검사일"},
            {"inspctInsttSeNm","검사기관" }
        };
        public string clsgn { get; set; }                                     //호출부호      
        public string befClsgn { get; set; }       //전호출부호    
        public string vsslNo { get; set; }                                     //      선박번호                                      
        public string imoNo { get; set; }                                     //     IMO번호                                      
        public string mmsiNo { get; set; }                                     //      MMSI번호                                      
        public string vsslKorNm { get; set; }                                     //  선박명(한글)                                      
        public string vsslEngNm { get; set; }                                     //  선박명(영문)                                      
        public string vsslNltyCd { get; set; }                                     //   선박국적(코드)                                      
        public string vsslNltyNm { get; set; }                                     //   선박국적(이름)                                      
        public string shipngNatCd { get; set; }                                     //    선적항(국적코드)                                      
        public string shipngPrtCd { get; set; }                                     //    선적항(항코드)                                      
        public string shipngPrtNm { get; set; }                                     //    선적항(이름)                                      
        public string vsslKndNm { get; set; }                                 //선박 종류
        public string grtg { get; set; }                                     //    총톤수                                      
        public string ntng { get; set; }                                     //    순톤수                                      
        public string intrlGrtg { get; set; }                                     //  국제총톤수                                      
        public string cmdtyWtTon { get; set; }                                     //   재화중량톤수                                      
        public string vsslTotLt { get; set; }                                     //  선박제원(총길이)                                      
        public string shdth { get; set; }                                     //     선박제원(너비)                                      
        public string vsslDrft { get; set; }                                     // 만재흘수                                      
        public string vsslDp { get; set; }                                     //      깊이                                      
        public string vsslLt { get; set; }                                     //      길이1                                      
        public string vsslCnstrDt { get; set; }                                     //    건    조일                                      
        public string shpwnrNltyCd { get; set; }                                     //     선주국적(코드)                                      
        public string shpwnrNltyNm { get; set; }                                     //     선주국적(이름)                                      
        public string shpwnrEntrpsCd { get; set; }                                     //       선주업체(코드)                                      
        public string shpwnrEntrpsNm { get; set; }                                     //       선주업체(이름)                                      
        public string oprtrNltyCd { get; set; }                                     //    운영자국적(코드)                                      
        public string oprtrNltyNm { get; set; }                                     //    운영자국적(이름)                                      
        public string oprtrEntrpsCd { get; set; }                                     //      운영자업체(코드)                                      
        public string oprtrEntrpsNm { get; set; }                                     //      운영자업체(이름)                                      
        public string satmntEntrpsCd { get; set; }                                     //       선사/대리점(코드)                                      
        public string satmntEntrpsNm { get; set; }                                     //       선사/대리점(이름)                                      
        public string nvgShapCd { get; set; }                                     //  운항형태                                      
        public string ibobprtSe { get; set; }                                     //  외내항구분                                      
        public string brbtSe { get; set; }                                     //      나용구분                                      
        public string okrDplcHullAt { get; set; }                                     //      유조선이중선체여부                                      
        public string sbtYn { get; set; }                                     //     SBT구조여부                                      
        public string lastInspctKndNm { get; set; }                                     //        최종검사정보                                      
        public string lastInspctDt { get; set; }                                     //     최종검사일                                      
        public string nxttrmInspctKndNm { get; set; }                                     //          차기검사종류                                      
        public string nxttrmInspctDt { get; set; }                                     //       차기검사일                                      
        public string inspctInsttSeNm { get; set; }                                     //        검사기관                    

        public List<cssVesselInfo> DataTableToClass(DataTable dt)
        {
            List<cssVesselInfo> lstData = new List<cssVesselInfo>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cssVesselInfo vi = new cssVesselInfo();
                PropertyInfo[] props = vi.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

                foreach (var property in props)
                {
                    string colName = string.Empty;
                    if (VesselDetailInfo.TryGetValue(property.Name, out colName))
                    {
                        property.SetValue(vi, dt.Rows[i][colName].ToString());
                    }
                }

                lstData.Add(vi);

            }


            return lstData;
        }
    }
   
}
