using GYIN.K3.SIASUN.SAP.BASESERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYIN.K3.SIASUN.SAP.BASESERVICE
{
    [Description("服务工厂类")]
     public class ServiceFactory
    {
        public static BaseOperation createOperation(string operate) {

            BaseOperation oper = null;
            switch (operate)
            {
                case "SAVE":
                    oper = new SaveOperation();
                    break;
                case "SUBMIT":
                    oper = new SubmitOperation();
                    break;
                case "DELETE":
                    oper = new DeleteOperation();
                    break;
                case "AUDIT":
                    oper = new AuditOperation();
                    break;
                default:
                    break;
            }
            return oper;
        }
    }
}
