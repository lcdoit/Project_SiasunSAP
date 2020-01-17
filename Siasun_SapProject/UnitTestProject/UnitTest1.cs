using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GYIN.K3.SIASUN.SAP.BASESERVICE;
using Kingdee.BOS.WebApi.Client;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        // [TestMethod]
        //public void testDll() {
        //    ApiClient client = new ApiClient("http://117.78.18.48:8090/k3cloud/");
        //    bool result = client.Login("5dc8fa6c951bed", "scy", "666666", 2052);
        //    if (result)
        //    {
        //        Console.WriteLine("登录成功！");
        //    }
        //}
        [TestMethod]
        public static void testFactory()
        {
            Console.WriteLine("进入工厂方法************************");
            BaseOperation oper = ServiceFactory.createOperation("SAVE");//保存
            BaseOperation.formId = "BD_Supplier";//FormId
            BaseOperation.targetJson = "{\"Creator\": \"\",\"NeedUpDateFields\": [],\"NeedReturnFields\": [],\"IsDeleteEntry\": \"true\",     \"SubSystemId\": \"\",     \"IsVerifyBaseDataField\": \"false\",     \"IsEntryBatchFill\": \"true\",     \"ValidateFlag\": \"true\",     \"NumberSearch\": \"true\",     \"InterationFlags\": \"\",\"IsAutoSubmitAndAudit\": \"false\",\"Model\": {    \"FSupplierId\": 0,    \"FCreateOrgId\": {   \"FNumber\": \"100\"    },    \"FNumber\": \"000011\",    \"FUseOrgId\": {   \"FNumber\": \"100\"    },    \"FName\": \"关印测试供应商001\",\"FShortName\": \"测试供应商001\",\"FBaseInfo\": {   \"FCountry\": {  \"FNumber\": \"China\"   },   \"FProvincial\": {  \"FNumber\": \"DQ007\"   },   \"FAddress\": \"辽宁沈阳浑南\",   \"FZip\": \"110000\",   \"FSupplyClassify\": \"CG\"    },    \"FBusinessInfo\": {   \"FVmiBusiness\": false,   \"FEnableSL\": false    },    \"FFinanceInfo\": {   \"FPayCurrencyId\": {  \"FNumber\": \"PRE001\"   },   \"FTaxType\": {  \"FNumber\": \"SFL02_SYS\"   },   \"FInvoiceType\": \"1\",   \"FTaxRateId\": {  \"FNUMBER\": \"SL02_SYS\"}}} }";//重新组装后的目标Json串
            Console.WriteLine("数据交换开始************************");
            oper.transform();//数据同步
            Console.WriteLine(oper.transform());
        }
        static void Main()
        {
            testFactory();
        }
    }
}
