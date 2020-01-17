using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYIN.K3.SIASUN.SAP.UTILS
{
    [Description("数据接口映射类父类")]
    public class BaseDataMapper
    {
        public Dictionary<string, object> getMapper() {
            return new Dictionary<string, object>();
        }
      

        //SAP与Cloud接口的字段映射关系 
        //格式为 mapper.Add("SAP字段","Cloud节点@Cloud字段");
        public BaseDataMapper() {
        

        }
    }
}
