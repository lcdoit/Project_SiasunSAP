using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYIN.K3.SIASUN.SAP.UTILS
{
    public class Model
    {
    }
        public class Root
    {
        public string Creator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> NeedUpDateFields { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> NeedReturnFields { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IsDeleteEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SubSystemId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IsVerifyBaseDataField { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IsEntryBatchFill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Model Model { get; set; }
    }
}
