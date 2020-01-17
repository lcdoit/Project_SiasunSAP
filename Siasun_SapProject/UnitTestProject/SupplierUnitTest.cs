﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GYIN.K3.SIASUN.SAP.BASESERVICE;
using GYIN.K3.SIASUN.SAP.UTILS;
using GYIN.K3.SIASUN.SAP.INTERFACE.供应商;

namespace UnitTestProject
{
    /// <summary>
    /// SupplierUnitTest 的摘要说明
    /// </summary>
    [TestClass]
    public class SupplierUnitTest
    {
        public SupplierUnitTest()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            BaseOperation oper = ServiceFactory.createOperation("SAVE");//保存
            BaseOperation.formId = "BD_Supplier";//FormId
            string sapJson = "{\"header\": { 		\"msgid\": \"0000000000000126\", 		\"interid\": \"PS001\", 		\"datetime\": 20200107111452, 		\"sender\": \"SAP\", 		\"receiver\": \"ERP\" 	}, 	\"body\": { 		\"partner\": \"\", 		\"name_org\": \"\", 		\"taxnum\": \"\", 		\"bank\": { 			\"bkvid\": \"1\", 			\"banks\": \"2\", 			\"bankl\": \"3\", 			\"banka\": \"4\", 			\"zbankn\": \"5\", 			\"swift\": \"6\" 		}, 		\"lfb1\": { 			\"bukrs\": \"7\" 		} 	} }";
            string targetJson =  DataTransfrom.getInstance().getTargetJsonStr(sapJson,new SupplierDataMapper());
            BaseOperation.targetJson = targetJson;
            oper.transform();//数据同步
        }
    }
}