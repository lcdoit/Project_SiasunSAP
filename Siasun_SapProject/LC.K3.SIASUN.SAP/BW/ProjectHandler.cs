using Kingdee.BOS.WebApi.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LC.K3.SIASUN.SAP.BW {
    /// <summary>
    /// 项目信息
    /// </summary>
    class ProjectHandler : IApiHandler {
        public bool Handle(ApiClient client, dynamic body,out string msg) {
            JToken jItem = ((JArray)body).First;

            string json = "{\"Creator\":\"\",\"NeedUpDateFields\":[],\"NeedReturnFields\":[],\"IsDeleteEntry\":\"True\",\"SubSystemId\":\"\",\"IsVerifyBaseDataField\":\"false\",\"IsEntryBatchFill\":\"True\",\"Model\":{\"FID\":\"0\","+
                "\"FNumber\":\""+ jItem["pspid"]+ "\",\"FCreateOrgId\":{\"FNumber\":\"0100\"},\"FUseOrgId\":{\"FNumber\":\"0100\"},"+
                "\"FName\":\""+ jItem["post1"]+"\",\"FDescription\":\"\",\"F_ZAX_Assistant\":{\"FNumber\":\"\"},\"F_ZAX_XMSSBM\":{\"FNumber\":\"0100\"},"
                +"\"F_ZAX_Xmlx\":{\"FNumber\":\""+"01"//jItem["profl"] 项目类型
                +"\"},\"FCust\":{\"FNumber\":\"\"},\"FISTQQD\":\"false\",\"FConstructionContract\":\"false\",\"FContractType\":\"\"," +
                "\"FEndDate\":\""+Helper.GetDateTimeString(Convert.ToString(jItem["plfaz"]))
                + "\",\"FStartDate\":\""+Helper.GetDateTimeString(Convert.ToString(jItem["plsez"]))+"\",\"FISINIT\":\"false\",\"FISSUSPEND\":\"false\"}}";
            //client.Save("ZAX_XS_XMXX")
            object[] saveInfo = new object[] { "ZAX_XS_XMXX", json };
            string result= client.Execute<string>("Kingdee.BOS.WebApi.ServicesStub.DynamicFormService.Save", saveInfo);

            JObject jo =(JObject) Newtonsoft.Json.JsonConvert.DeserializeObject(result);
            
            if(Convert.ToString( jo["Result"]["ResponseStatus"]["IsSuccess"]) == "True") {
                msg = Convert.ToString( jo["Result"]["ResponseStatus"]["SuccessMessages"]);
                return true;
            }
            msg = Convert.ToString(jo["Result"]["ResponseStatus"]["Errors"]); 
            return false;
        }

    }
}
