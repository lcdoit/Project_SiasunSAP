using Kingdee.BOS.WebApi.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYIN.K3.SIASUN.SAP.BASESERVICE
{
    [Description("单据操作类")]

    //保存（新增保存和修改保存通用）
    public class SaveOperation : BaseOperation
    {
        public override string transform()
        {
            string result = "保存操作结果：";
            K3CloudApiClient client = getOperateClient();
            result += client.Save(formId, targetJson);
            return result;
        }
    }
    //提交（新增保存和修改保存通用）
    public class SubmitOperation : BaseOperation
    {
        public override string transform()
        {
            string result = "提交操作结果：";
            K3CloudApiClient client = getOperateClient();
            result += client.Submit(formId, targetJson);
            return result;
        }
    }
    //删除
    public class DeleteOperation : BaseOperation
    {
        public override string transform()
        {
            string result = "删除操作结果：";
            K3CloudApiClient client = getOperateClient();
            result += client.Delete(formId, targetJson);
            return result;
        }
    }
    //审核
    public class AuditOperation : BaseOperation
    {
        public override string transform()
        {
            string result = "审核操作结果：";
            K3CloudApiClient client = getOperateClient();
            result += client.Audit(formId, targetJson);
            return result;
        }
    }
}

