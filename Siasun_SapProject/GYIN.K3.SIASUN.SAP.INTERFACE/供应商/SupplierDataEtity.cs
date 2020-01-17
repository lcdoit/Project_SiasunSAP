using GYIN.K3.SIASUN.SAP.UTILS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYIN.K3.SIASUN.SAP.INTERFACE.供应商
{
    [Description("供应商数据实体类")]
    public class SupplierDataEtity
    {
        public class FCreateOrgId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FUseOrgId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FGroup
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FCorrespondOrgId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FForbiderId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FUserID { get; set; }
        }

        public class FPurchaseDept
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class Fpurchaser
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FCountry
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FProvincial
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FCity
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FLanguage
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FTrade
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FDeptId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FStaffId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FSupplierClassify
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FSupplierGrade
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FCompanyClassify
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FCompanyNature
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FCompanyScale
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FBaseInfo
        {
            /// <summary>
            /// 
            /// </summary>
            public FCountry FCountry { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FProvincial FProvincial { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FCity FCity { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FAddress { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FZip { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FLanguage FLanguage { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FWebSite { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FTrade FTrade { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FFoundDate { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FLegalPerson { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FRegisterFund { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FSOCIALCRECODE { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FRegisterCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FTendPermit { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FRegisterAddress { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FDeptId FDeptId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FStaffId FStaffId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FSupplierClassify FSupplierClassify { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FSupplyClassify { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FSupplierGrade FSupplierGrade { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FCompanyClassify FCompanyClassify { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FCompanyNature FCompanyNature { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FCompanyScale FCompanyScale { get; set; }
        }

        public class FFreezeOperator
        {
            /// <summary>
            /// 
            /// </summary>
            public string FUserID { get; set; }
        }

        public class FPurchaserGroupId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FParentSupplierId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FSettleTypeId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FPRICELISTID
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FDiscountListId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FProviderId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWipStockId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWIPSTOCKPLACEID__FF100501
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWIPSTOCKPLACEID__FF100502
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWIPSTOCKPLACEID__FF100503
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWIPSTOCKPLACEID__FF100504
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWIPSTOCKPLACEID__FF100505
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWIPSTOCKPLACEID__FF100506
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWIPSTOCKPLACEID__FF100507
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWIPSTOCKPLACEID__FF100508
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWIPSTOCKPLACEID__FF100509
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWIPSTOCKPLACEID__FF100510
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FWipStockPlaceId
        {
            /// <summary>
            /// 
            /// </summary>
            public FWIPSTOCKPLACEID__FF100501 FWIPSTOCKPLACEID__FF100501 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWIPSTOCKPLACEID__FF100502 FWIPSTOCKPLACEID__FF100502 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWIPSTOCKPLACEID__FF100503 FWIPSTOCKPLACEID__FF100503 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWIPSTOCKPLACEID__FF100504 FWIPSTOCKPLACEID__FF100504 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWIPSTOCKPLACEID__FF100505 FWIPSTOCKPLACEID__FF100505 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWIPSTOCKPLACEID__FF100506 FWIPSTOCKPLACEID__FF100506 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWIPSTOCKPLACEID__FF100507 FWIPSTOCKPLACEID__FF100507 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWIPSTOCKPLACEID__FF100508 FWIPSTOCKPLACEID__FF100508 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWIPSTOCKPLACEID__FF100509 FWIPSTOCKPLACEID__FF100509 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWIPSTOCKPLACEID__FF100510 FWIPSTOCKPLACEID__FF100510 { get; set; }
        }

        public class FVmiStockId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FBusinessInfo
        {
            /// <summary>
            /// 
            /// </summary>
            public FFreezeOperator FFreezeOperator { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FFreezeDate { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FPurchaserGroupId FPurchaserGroupId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FParentSupplierId FParentSupplierId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FSettleTypeId FSettleTypeId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FPRICELISTID FPRICELISTID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FDiscountListId FDiscountListId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FProviderId FProviderId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWipStockId FWipStockId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FVmiBusiness { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FWipStockPlaceId FWipStockPlaceId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FVmiStockId FVmiStockId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FEnableSL { get; set; }
        }

        public class FCustomerId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FPayCurrencyId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FPayCondition
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FSettleId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FTaxType
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FChargeId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FTaxRateId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FFinanceInfo
        {
            /// <summary>
            /// 
            /// </summary>
            public FCustomerId FCustomerId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FPayCurrencyId FPayCurrencyId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FPayCondition FPayCondition { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FSettleId FSettleId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FPayAdvanceAmount { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FTaxType FTaxType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FTaxRegisterCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FChargeId FChargeId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FInvoiceType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FTaxRateId FTaxRateId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FFinanceDesc { get; set; }
        }

        public class FBankCountry
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FBankTypeRec
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FBankCurrencyId
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FBankInfoItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string FBankId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FBankCountry FBankCountry { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FOpenBankName { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FBankCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FBankHolder { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FBankTypeRec FBankTypeRec { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FTextBankDetail { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FOpenAddressRec { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FCNAPS { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FSwiftCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FBankCurrencyId FBankCurrencyId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FBankIsDefault { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FBankDesc { get; set; }
        }

        public class FLocNewContact
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class FLocationInfoItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string FLocationId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FLocName { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FLocNewContact FLocNewContact { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FLocAddress { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FLocMobile { get; set; }
        }

        public class FSupplierContactItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string FContactId { get; set; }
        }

        public class F_PAEZ_Base
        {
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
        }

        public class F_PAEZ_EntityItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string FEntryID { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public F_PAEZ_Base F_PAEZ_Base { get; set; }
        }

        public class Model
        {
            /// <summary>
            /// 
            /// </summary>
            public string FSupplierId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FCreateOrgId FCreateOrgId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FNumber { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FUseOrgId FUseOrgId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FName { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FShortName { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FGroup FGroup { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FCorrespondOrgId FCorrespondOrgId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FDescription { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FForbiderId FForbiderId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FForbidDate { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FSupplierGroup { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FPurchaseDept FPurchaseDept { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Fpurchaser Fpurchaser { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FWLS { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FIsAllot { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string FComRelizeNepg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string F_SFKD_IsAgreeSupplier { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string F_SFKD_IsFundPool { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FBaseInfo FBaseInfo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FBusinessInfo FBusinessInfo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public FFinanceInfo FFinanceInfo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<FBankInfoItem> FBankInfo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<FLocationInfoItem> FLocationInfo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<FSupplierContactItem> FSupplierContact { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<F_PAEZ_EntityItem> F_PAEZ_Entity { get; set; }
        }
        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
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
}