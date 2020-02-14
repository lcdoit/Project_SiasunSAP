using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using Kingdee.BOS.WebApi.ServicesStub;
using Kingdee.BOS.ServiceFacade.KDServiceFx;
using Kingdee.BOS.WebApi.Client;
using LC.K3.SIASUN.SAP;
using Newtonsoft.Json;
using Kingdee.BOS.JSON;

namespace GYIN.K3.SIASUN.SAP.BASESERVICE
{
    [Description("基础请求类")]
    public class BaseRequest: AbstractWebApiBusinessService
    {
        public BaseRequest(KDServiceContext context)
            : base(context) { }

        public JsonObject doPost(string jsonStr) {
            Helper.WriteLog(string.Format("{0} INFO {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), jsonStr));//写入日志
            JObject obj = (JObject)JsonConvert.DeserializeObject(jsonStr);
            dynamic header = obj["header"];
            string dbId, msgid = "0", interid = "0", sender = "", receiver = "";
            ParseHeader(header, out dbId, out msgid, out interid, out sender, out receiver);
          

            return null;
        }

        private void ParseHeader(dynamic header, out object dbId, out object msgid, out object interid, out object sender, out object receiver)
        {
            throw new NotImplementedException();
        }

        public static JSONObject GetReturnObject(string msgid, string interid, string sender, string receiver, string msg, string actType, string status)
        {
            JSONObject jo = new JSONObject();
            jo.Add("msgid", msgid);
            jo.Add("interid", interid);
            jo.Add("datetime", DateTime.Now.ToString("yyyyMMddHHmmss"));
            jo.Add("sender", sender);
            jo.Add("receiver", receiver);
            jo.Add("msg", msg.Length > 200 ? msg.Substring(0, 200) : msg);
            jo.Add("acktype", "T");
            jo.Add("status", "E");
            JSONObject result = new JSONObject();
            result.Add("header", jo);
            return result;
        }
        public static void ParseHeader(dynamic header, out string dbid, out string msgid, out string interid, out string sender, out string receiver)
        {
            if (header == null)
                throw new Exception("header 为空！");
            dbid = header.dbid;
            msgid = header.msgid;
            interid = header.interid;
            sender = header.sender;
            receiver = header.receiver;
        }





    }
}
