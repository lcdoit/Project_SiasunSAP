using Kingdee.BOS.WebApi.Client;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LC.K3.SIASUN.SAP {
    /// <summary>
    /// 项目信息
    /// </summary>
    class MaterialHandler : IApiHandler {
        public bool Handle(ApiClient client, dynamic body,out string msg) {
            msg = "测试";
            return true;
        }

    }
}
