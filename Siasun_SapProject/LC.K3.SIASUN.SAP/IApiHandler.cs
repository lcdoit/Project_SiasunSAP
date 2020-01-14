using Kingdee.BOS.WebApi.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LC.K3.SIASUN.SAP {
    public interface IApiHandler {
        bool Handle(ApiClient client, dynamic body,out string msg);
    }
}
