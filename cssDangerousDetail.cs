using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PortMisDataToDB
{
    public class cssDangerousDetail
    {
        private Dictionary<string, string> dicDangerousDetail = new Dictionary<string, string>()
        {
            {"idx","순번"},
            {"prtAgCd","청명(코드)"},
            {"prtAtNm","청명(이름)"},
            {"clsgn","호출부호"},
            {"vsslNm","선박명"},
            {"useTrget1","사용목적1(코드)"},
            {"useTrgetNm1","사용목적1(이름)"},
            {"useTrget2","사용목적2(코드)"},
            {"useTrgetNm2","사용목적2(이름)"},
            {"tkinSe","반입구분(코드)"},
            {"tkinNm","반입구분(이름)"},
            {"etryptYear","입항년도"},
            {"etryptCo","횟수"},
            {"tnspotShapCd1","운송형태1(코드)"},
            {"tnspotShapNm1","운송형태1(이름)"},
            {"tnspotShapCd2","운송형태2(코드)"},
            {"tnspotShapNm2","운송형태2(이름)"},
            {"frghtNm","화물명"},
            {"contnCo","컨테이너갯수"},
            {"wt","총량"},
            {"lnlEntrpsCd","하역업체코드"},
            {"lnlEntrpsNm","하역업체명"},
            {"entrpsCd","신고업체코드"},
            {"entrpsNm","신고업체명"},
            {"beginUseDt","사용일자(시작)"},
            {"endUseDt","사용일자(종료)"},
            {"usePlaceCd","사용장소(부두:코드)"},
            {"usePlaceSubCd","사용장소(부두:번호)"},
            {"facilNm","사용장소(부두:이름)"},
            {"reqstDt","신고일시"},
            {"cnnctnId","EDI ID"},
            {"prvsDpmprtNatCd","전출항지(코드)"},
            {"prtNm","전출항지(이름)"},
            {"preApplcDt","수리일자"},
            {"rm","비고"},

        };
        //public string idx { get; set; }                //순번                
        public string prtAgCd { get; set; }            //청명(코드)                              
        public string prtAtNm { get; set; }            //청명(이름)                               
        public string clsgn { get; set; }              //호출부호                         
        public string vsslNm { get; set; }             //선박명                         
        public string useTrget1 { get; set; }          //사용목적1(코드)                                        
        public string useTrgetNm1 { get; set; }        //사용목적1(이름)                                            
        public string useTrget2 { get; set; }          //사용목적2(코드)                                        
        public string useTrgetNm2 { get; set; }        //사용목적2(이름)                                            
        public string tkinSe { get; set; }             //반입구분(코드)                                 
        public string tkinNm { get; set; }             //반입구분(이름)                                 
        public string etryptYear { get; set; }         //입항년도                                   
        public string etryptCo { get; set; }           //횟수                           
        public string tnspotShapCd1 { get; set; }      //운송형태1(코드)                                                
        public string tnspotShapNm1 { get; set; }      //운송형태1(이름)                                                
        public string tnspotShapCd2 { get; set; }      //운송형태2(코드)                                                
        public string tnspotShapNm2 { get; set; }      //운송형태2(이름)                                                
        public string frghtNm { get; set; }            //화물명                           
        public string contnCo { get; set; }            //컨테이너갯수                                 
        public string wt { get; set; }                 //총량               
        public string lnlEntrpsCd { get; set; }        //하역업체(코드)                                           
        public string lnlEntrpsNm { get; set; }        //하역업체명                                       
        public string entrpsCd { get; set; }           //신고업체(코드)                                     
        public string entrpsNm { get; set; }           //신고업체명                                 
        public string beginUseDt { get; set; }         //사용일자(시작)                                         
        public string endUseDt { get; set; }           //사용일자(종료)                                     
        public string usePlaceCd { get; set; }         //사용장소(부두:코드)                                              
        public string usePlaceSubCd { get; set; }      //사용장소(부두:번호)                                                    
        public string facilNm { get; set; }            //사용장소(부두:이름)                                        
        public string reqstDt { get; set; }            //신고일시                             
        public string cnnctnId { get; set; }           //EDIID                             
        public string prvsDpmprtNatCd { get; set; }    //전출항지(코드)                                                   
        public string prtNm { get; set; }              //전출항지(이름)                               
        public string preApplcDt { get; set; }         //수리일자                                   
        public string rm { get; set; }                 //비고         

        public List<cssDangerousDetail> DataTableToClass(DataTable dt)
        {
            List<cssDangerousDetail> lstData = new List<cssDangerousDetail>();

            if (dt == null) return lstData;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cssDangerousDetail vio = new cssDangerousDetail();
                PropertyInfo[] props = vio.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

                foreach (var property in props)
                {
                    string colName = string.Empty;
                    if (dicDangerousDetail.TryGetValue(property.Name, out colName))
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

