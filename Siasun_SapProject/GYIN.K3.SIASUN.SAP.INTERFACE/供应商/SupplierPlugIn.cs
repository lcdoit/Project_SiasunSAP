using GYIN.K3.SIASUN.SAP.BASESERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYIN.K3.SIASUN.SAP.INTERFACE
{
    [Description("供应商数据交换接口类")]
    public class SupplierPlugIn: BaseOperation
    {
        public string jsonStr = "";
        public string FormId = "BD_Supplier";
        public string saveData(string json) {
            BaseOperation oper = ServiceFactory.createOperation("SAVE");//保存
            BaseOperation.formId = FormId;//FormId
            BaseOperation.targetJson = "";//重新组装后的目标Json串
            return oper.transform();//数据同步 
        }  
       
    }
}
