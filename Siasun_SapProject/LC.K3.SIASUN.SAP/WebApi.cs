using Kingdee.BOS.Core.Bill;
using Kingdee.BOS.Core.DynamicForm;
using Kingdee.BOS.Core.Metadata;
using Kingdee.BOS.JSON;
using Kingdee.BOS.ServiceFacade.KDServiceFx;
using Kingdee.BOS.WebApi.ServicesStub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Kingdee.BOS.WebApi.Client;

namespace LC.K3.SIASUN.SAP {
    public class WebApi : AbstractWebApiBusinessService {
        public WebApi(KDServiceContext context)
            : base(context) { }


        /// <summary>
        /// {"BillNO":"FBDR000055","qty":"3","LossQty":"0"}
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public JSONObject Post(string parameter) {
            Helper.WriteLog(string.Format("{0} INFO {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), parameter));
            //CHUtils.isCloudSSO(context);
            JObject jo = (JObject)JsonConvert.DeserializeObject(parameter);
            dynamic header = jo["header"];
            //JSONArray jsonArray = new JSONArray();

            string dbId, msgid = "0", interid = "0", sender = "", receiver = "";
            try {
                //如何获取当前服务器的URL
                ApiClient client = new ApiClient("http://localhost/k3cloud/");
                ParseHeader(header, out dbId, out msgid, out interid, out sender, out receiver);
                //string dbId = "5e154dea19ae34";//"5dbbdd2ac57413"; //AotuTest117
                bool bLogin = client.Login(dbId, "jinyh", "888888", 2052);
                if (!bLogin)
                    throw new Exception("登录失败");
                IApiHandler handler;
                switch (interid) {
                    case "PS001"://项目信息
                        handler = new BW.ProjectHandler();
                        break;
                    case "FICO005"://物料主数据接口
                        handler = new MaterialHandler();
                        break;
                    default:
                        throw new Exception("未知的interid:" + interid);
                }
                string msg;
                bool isSuccess= handler.Handle(client, jo["body"],out msg);

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
        public static void ParseHeader(dynamic header,out string dbid, out string msgid, out string interid, out string sender, out string receiver) {
            if (header == null) 
                throw new Exception("header 为空！");
#if DEBUG
            dbid = "5c55964802a991";
#else
            dbid = "5c55964802a991";
#endif
            msgid = header.msgid;
            interid = header.interid;
            sender = header.sender;
            receiver = header.receiver;
        }
    }
}
