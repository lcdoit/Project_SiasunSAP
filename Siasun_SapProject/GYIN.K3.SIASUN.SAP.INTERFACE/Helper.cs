using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYIN.K3.SIASUN.SAP.INTERFACE
{
    public static class Helper {
        public static string GetDateTimeString(string val) {
            if (string.IsNullOrEmpty(val) || val.Length!=8)
                return "1900-01-01";
            return string.Format("{0}-{1}-{2}", val.Substring(0, 4), val.Substring(4, 2), val.Substring(6, 2));
        }
        public static void WriteLog(string log) {
            string filePath = string.Format(@"{0}App_Data\Log\{1}\sap.log", AppDomain.CurrentDomain.BaseDirectory, DateTime.Today.ToString("yyyy-MM-dd"));
            Kingdee.BOS.Log.FileLog.WriteLogFile(filePath, log);
        }
    }
}
