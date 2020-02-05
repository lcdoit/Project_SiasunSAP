using GYIN.K3.SIASUN.SAP.UTILS;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GYIN.K3.SIASUN.SAP.UTILS
{
    [Description("数据转换工具类")]
    public  class DataTransfrom
    {
        public static DataTransfrom getInstance() {
            DataTransfrom dtObj = null;
            if (dtObj == null)
            {
                dtObj = new DataTransfrom();
            }
            return dtObj;
        }

        //获得目标Json字符串
        public string getTargetJsonStr(string sourceJsonStr, Dictionary<string, object> mapper) {
            string targetJson = "";
            JObject jsonRoot = new JObject();
            JObject entryList = new JObject();
            JArray entrys = new JArray();//单个model中存储多行分录体集合，存储mBentry
            StringBuilder builder = new StringBuilder("{");
           // Root rt = new Root();//根节点
         //   Model m = new Model();//Model节点
           // Object rootObj = getDataObject("Root");//类对象
          //  Object modelObj = getDataObject("Model");//Model节点对象
          //  Object modelListObj = getListObj("GYIN.K3.SIASUN.SAP.INTERFACE.供应商.SupplierDataEtity.Model", "FBankInfo");//Model节点下的List对象    
           // tempListProperty.SetValue(obj, tempList, null);
          //  Type type = rt.GetType();      
          //  PropertyInfo[] properties = type.GetProperties();
          //   Dictionary<string, object> map = mapper.getMapper();
            string[] str = sourceJsonStr.Substring(8, sourceJsonStr.Length - 2).Split(',');
            foreach (var item in str)
            {
                string[] keyValue = item.Split(':');
                object cloudAttribute = mapper[keyValue[0]];
                string node = Convert.ToString(cloudAttribute);//Cloud对应的节点字段信息
                string[] a = node.Split('>');
                string attributeName = a[1];//属性名称
                string higherLevelNode = "";//上级节点
             //   PropertyInfo rootInfo = rt.GetType().GetProperty(attributeName); //获取指定名称的属性
            //    PropertyInfo modelInfo = m.GetType().GetProperty(attributeName); //获取指定名称的属性 
                if (a!= null && a.Length==2)
                {
                    attributeName = a[1];
                    higherLevelNode = a[0];
                }
                if (higherLevelNode.Equals("@Root"))
                {
                    jsonRoot.Add(attributeName, keyValue[1]);
                }else if (higherLevelNode.Equals("@Model"))
                {
                    entryList.Add(attributeName, keyValue[1]);
                }
                jsonRoot.Add("entry", entrys);
                targetJson = JsonConvert.SerializeObject(jsonRoot);         
            }
            return targetJson;
        }


       
        public Object getDataObject(string className) {
            Type type = Type.GetType(className);      // 通过类名获取同名类
            object obj = System.Activator.CreateInstance(type);       // 创建实例
            return obj;
        }
        public Object getListObj(string className, string listName) {
            Object obj = getDataObject(className);
            var tempListProperty = obj.GetType().GetProperty(listName);//列名
            var tempList = obj.GetType().Assembly.CreateInstance(tempListProperty.PropertyType.FullName);//List对象
            return tempList;
        }
    }
}
