using Kingdee.BOS.JSON;
using Kingdee.BOS.ServiceFacade.KDServiceFx;
using Kingdee.BOS.WebApi.ServicesStub;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Kingdee.BOS.WebApi.Client;
using GYIN.K3.SIASUN.SAP.BASESERVICE;

namespace GYIN.K3.SIASUN.SAP.INTERFACE
{
    public class WebApi : AbstractWebApiBusinessService {
        public WebApi(KDServiceContext context)
            : base(context) { }
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public JSONObject Post(string parameter) {
            Helper.WriteLog(string.Format("{0} INFO {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), parameter));
            //CHUtils.isCloudSSO(context);
            JObject jo = (JObject)JsonConvert.DeserializeObject(parameter);
            dynamic header = jo["header"]; 
            string  msgid = "0", interid = "0", sender = "", receiver = "";
            try {
                //如何获取当前服务器的URL
                K3CloudApiClient client = new K3CloudApiClient(Constants.CLIENT_URL);
                ParseHeader(header, Constants.DBID, out msgid, out interid, out sender, out receiver);
                bool bLogin = client.Login(Constants.DBID, Constants.USERNAME, Constants.PASSWORD, Constants.ICID);
                if (!bLogin)
                    throw new Exception("登录失败");
                IApiHandler handler;
                switch (interid) {
                    case "gys"://供应商
                        handler = new SupplierPlugIn();
                        break;
                    case "kh"://客户
                        handler = new CustomerPlugIn();
                        break;

                    default:
                        throw new Exception("未知的interid:" + interid);
                }
                string msg = "";
                bool isSuccess= handler.save(client, jo["body"]);
                if (isSuccess)
                {
                    if (handler.submit(client))//提交
                    {
                        handler.audit(client,out msg);//审核
                    }
                }
                Helper.WriteLog(string.Format("{0} INFO interid:{1} msgid:{2} result:{3} msg:{4}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), interid, msgid, isSuccess, msg));

                return GetReturnObject(msgid, interid, sender, receiver, msg, "P", isSuccess ? "S" : "E");
            }
            catch (Exception ex) {
                Helper.WriteLog(string.Format("{0} ERR msg:{1} stackTrace:{2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), ex.Message , ex.StackTrace));
                return GetReturnObject(msgid, interid, sender, receiver, ex.Message,"T","E");
            }
        }

        public static JSONObject GetReturnObject(string msgid,string interid,string sender,string receiver, string msg,string actType,string status) {
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
        public static void ParseHeader(dynamic header,string dbid, out string msgid, out string interid, out string sender, out string receiver) {
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
