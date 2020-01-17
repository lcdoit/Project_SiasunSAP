using Kingdee.BOS.WebApi.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYIN.K3.SIASUN.SAP.BASESERVICE
{
    [Description("所有接口的父类")]
    public class BaseOperation
    {
        public static string formId { get; set; }//FormId
        public static string targetJson { get; set; }//目标Json串

        //获取客户端对象 K3CloudApiClient
        public static ApiClient getClient()
        {
            ApiClient client = null;
            if (client == null)
            {
                client = new ApiClient("http://117.78.18.48:8090/k3cloud/");
            }
            return client;
        }
        public static K3CloudApiClient getOperateClient()
        {
            K3CloudApiClient client = null;
            if (client == null)
            {
                client = new K3CloudApiClient(Constants.CLIENT_URL);
                var ret = client.ValidateLogin(Constants.DBID, Constants.USERNAME, Constants.PASSWORD, 2052);//登录校验
                var result = JObject.Parse(ret)["LoginResultType"].Value<int>();
                // 登录成功
                if (result == 1)
                {
                    return client;
                }
            }
            return client;
        }
        //登录Cloud系统
        public static bool loginSYS()
        {
            return getClient().Login("5dc8fa6c951bed", "scy", "666666", 2052);
        }



        public virtual bool login()
        {
            bool flag = false;
            return flag;
        }

        public virtual string transform()
        {
            string result = "";
            return result;
        }
        //数据转换
    }
}
