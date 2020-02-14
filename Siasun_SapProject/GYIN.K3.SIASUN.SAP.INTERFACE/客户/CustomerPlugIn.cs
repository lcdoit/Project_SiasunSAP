using GYIN.K3.SIASUN.SAP.BASESERVICE;
using Kingdee.BOS.WebApi.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYIN.K3.SIASUN.SAP.INTERFACE
{
    [Description("客户数据交换接口类")]
    public class CustomerPlugIn : IApiHandler
    {
        public string saveStr = "";
        public string submitStr = "{\"CreateOrgId\":\"01\",\"Numbers\":[],\"Ids\":\"\"}";
        public string auditStr = "{\"CreateOrgId\":\"01\",\"Numbers\":[],\"Ids\":\"\"}";
        public string FormId = "BD_Customer";
   
     //保存
        public bool save(K3CloudApiClient client, dynamic body)
        {
            JToken jItem = ((JArray)body).First;
            saveStr = "{\"Creator\":\"\",\"NeedUpDateFields\":[],\"NeedReturnFields\":[],\"IsDeleteEntry\":\"True\",\"SubSystemId\":\"\",\"IsVerifyBaseDataField\":\"false\",\"IsEntryBatchFill\":\"True\",\"Model\":{\"FSupplierId\":0,\"FCreateOrgId\":{\"FNumber\":\"01\"},\"FUseOrgId\":{\"FNumber\":\"01\"},\"FName\":\"" + jItem["name_org"] + "\",\"FSupplierGroup\":\"1\",\"FWLS\":false,\"FIsAllot\":false,\"F_SFKD_IsAgreeSupplier\":false,\"F_SFKD_IsFundPool\":false,\"FBaseInfo\":{\"FCountry\":{\"FNumber\":\"China\"},\"FProvincial\":{\"FNumber\":\"06\"},\"FSOCIALCRECODE\":\"" + jItem["taxnum"] + "\",\"FSupplyClassify\":\"CG\"},\"FBusinessInfo\":{\"FVmiBusiness\":false,\"FEnableSL\":false},\"FFinanceInfo\":{\"FPayCurrencyId\":{\"FNumber\":\"PRE001\"},\"FTaxType\":{\"FNumber\":\"SFL02_SYS\"},\"FInvoiceType\":\"1\",\"FTaxRateId\":{\"FNumber\":\"SL02_SYS\"}},\"FBankInfo\":[{\"FBankCountry\":{\"FNumber\":\"" + jItem["banks"] + "\"},\"FOpenBankName\":\"" + jItem["banka"] + "\",\"FBankCode\":\"" + jItem["zbankn"] + "\",\"FBankHolder\":\"关印测试供应商001\",\"FSwiftCode\":\"666\",\"FBankIsDefault\":false}]}}";
            string result = client.Save(FormId, saveStr);
            return judgeIsSuccess(result);
        }
       //提交
        public bool submit(K3CloudApiClient client) {
            string result = client.Submit(FormId, submitStr);
            return judgeIsSuccess(result);
        }
        //审核
        public bool audit(K3CloudApiClient client, out string msg)
        {
            bool flag = false;
            string result = client.Audit(FormId, auditStr);
            JObject jo = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(result);
            if (Convert.ToString(jo["Result"]["ResponseStatus"]["IsSuccess"]) == "True")
            {
                msg = Convert.ToString(jo["Result"]["ResponseStatus"]["SuccessMessages"]);
                flag = true;
            }
            else {
                msg = Convert.ToString(jo["Result"]["ResponseStatus"]["Errors"]);
            }          
            return flag;
        }
        //根据响应结果判断操作是否成功
        public bool judgeIsSuccess(string result) {
            bool flag = false;
            JObject jo = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(result);
            if (Convert.ToString(jo["Result"]["ResponseStatus"]["IsSuccess"]) == "True")
            {
                flag = true;
            }
            return flag;
        }



        //  public string saveData(string json) {
        //     JObject obj = JObject.Parse(jsonStr);//解析Json串
        //      BaseOperation oper = ServiceFactory.createOperation("SAVE");//保存
        //     BaseOperation.formId = FormId;//FormId
        //     StringBuilder buffer = new StringBuilder();
        //     BaseOperation.targetJson = "{\"Creator\":\"\",\"NeedUpDateFields\":[],\"NeedReturnFields\":[],\"IsDeleteEntry\":\"True\",\"SubSystemId\":\"\",\"IsVerifyBaseDataField\":\"false\",\"IsEntryBatchFill\":\"True\",\"Model\":{\"FSupplierId\":0,\"FCreateOrgId\":{\"FNumber\":\"01\"},\"FUseOrgId\":{\"FNumber\":\"01\"},\"FName\":\""+obj["name_org"]+"\",\"FSupplierGroup\":\"1\",\"FWLS\":false,\"FIsAllot\":false,\"F_SFKD_IsAgreeSupplier\":false,\"F_SFKD_IsFundPool\":false,\"FBaseInfo\":{\"FCountry\":{\"FNumber\":\"China\"},\"FProvincial\":{\"FNumber\":\"06\"},\"FSOCIALCRECODE\":\""+ obj["taxnum"] + "\",\"FSupplyClassify\":\"CG\"},\"FBusinessInfo\":{\"FVmiBusiness\":false,\"FEnableSL\":false},\"FFinanceInfo\":{\"FPayCurrencyId\":{\"FNumber\":\"PRE001\"},\"FTaxType\":{\"FNumber\":\"SFL02_SYS\"},\"FInvoiceType\":\"1\",\"FTaxRateId\":{\"FNumber\":\"SL02_SYS\"}},\"FBankInfo\":[{\"FBankCountry\":{\"FNumber\":\"Japan\"},\"FOpenBankName\":\"中国农业银行\",\"FBankCode\":\"62100231223345555511\",\"FBankHolder\":\"关印测试供应商001\",\"FSwiftCode\":\"666\",\"FBankIsDefault\":false}]}}";//重新组装后的目标Json串
        //     return oper.transform();//数据同步 
        //   }  

    }
}
