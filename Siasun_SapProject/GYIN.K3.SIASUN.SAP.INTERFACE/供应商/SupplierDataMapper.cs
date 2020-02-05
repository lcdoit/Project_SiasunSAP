
using GYIN.K3.SIASUN.SAP.UTILS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYIN.K3.SIASUN.SAP.INTERFACE.供应商
{
    [Description("数据转换工具类")]
    public class SupplierDataMapper : BaseDataMapper
    {
        private Dictionary<string, object> mapper;

        //1）根节点属性；Root>Creator
        //2）Model节点下属性Root>Model>FSupplierId
        //3）Model节点下集合Root>Model>FBankInfo>FBankId
        //4）Model节点下集合Root>Model>FBankInfo>FBankCountry>FNumber
        //4）Model节点下对象Root>Model>FBusinessInfo>FFreezeOperator>FUserID
        public new Dictionary<string, object>  getMapper()
        {
             //mapper = base.getMapper();

             mapper.Add("sapCrator", "@Root>$Creator>");//创建人
             mapper.Add("sapCustid", "@Model>$FCUSTID>");//客户ID
            return mapper;
        }
      //  public SupplierDataMapper() {
       //     Dictionary<string, object> supplierMapper = getMapper();
        //    supplierMapper.Add("sapCrator", "@Root>$Creator>");//创建人
        //    supplierMapper.Add("sapCustid", "@Model>$FCUSTID>");//客户ID
         // mapper.Add("banks", "@Root-@Model-List<FBankInfoItem>-$FBankCountry>");//银行国家
         // mapper.Add("bankl", "@Root-@Model-List<FBankInfoItem>-@FBankCountry-$FNumber");//银行代码
        }
    }

