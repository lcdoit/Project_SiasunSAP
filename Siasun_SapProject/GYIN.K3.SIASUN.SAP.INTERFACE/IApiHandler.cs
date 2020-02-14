using Kingdee.BOS.WebApi.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYIN.K3.SIASUN.SAP.INTERFACE
{
    public interface IApiHandler {
     //   bool Handle(ApiClient client, dynamic body,out string msg);
        bool save(K3CloudApiClient client, dynamic body);
        bool submit(K3CloudApiClient client);
        bool audit(K3CloudApiClient client, out string msg);
    }
}
