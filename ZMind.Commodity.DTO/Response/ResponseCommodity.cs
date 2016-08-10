using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZMind.Commodity.DTO.Response
{
    [DataContract]
    public class ResponseCommodity
    {
        [DataMember]
        public bool IsSuccess { get; set; }
        [DataMember]
        public string ErrorCode { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public int TotalCount { get; set; }
        [DataMember]
        public List<Commodity> ResponseCommodityDetailList { get; set; }
    }
    [DataContract]
    public class Commodity
    {
        [DataMember]
        public string ItemId { get; set; }
        [DataMember]
        public string ItemCategoryId { get; set; }
        [DataMember]
        public string ItemCode { get; set; }
        [DataMember]
        public string ItemName { get; set; }
        [DataMember]
        public string ItemNameEn { get; set; }
        [DataMember]
        public string ItemNameShort { get; set; }
        [DataMember]
        public string Pyzjm { get; set; }
        [DataMember]
        public string ItemRemark { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string StatusDesc { get; set; }
        [DataMember]
        public string CreateUserId { get; set; }
        [DataMember]
        public string CreateTime { get; set; }
        [DataMember]
        public string ModifyUserId { get; set; }
        [DataMember]
        public string ModifyTime { get; set; }
        [DataMember]
        public string BatId { get; set; }
        [DataMember]
        public string IfFlag { get; set; }
        [DataMember]
        public string IfGifts { get; set; }
        [DataMember]
        public string IfOften { get; set; }
        [DataMember]
        public string IfService { get; set; }
        [DataMember]
        public string IsGb { get; set; }
        [DataMember]
        public string DataFrom { get; set; }
        [DataMember]
        public string DisplayIndex { get; set; }
        [DataMember]
        public string ImageUrl { get; set; }
        [DataMember]
        public string ImageUrlFirst { get; set; }
        [DataMember]
        public string ImageUrl2 { get; set; }
        [DataMember]
        public string ImageUrl3 { get; set; }
        [DataMember]
        public string CustomerId { get; set; }
        [DataMember]
        public string PTypeId { get; set; }
        [DataMember]
        public string PTypeCode { get; set; }
        [DataMember]
        public string Tel { get; set; }
        [DataMember]
        public string ItemUnit { get; set; }
        [DataMember]
        public string Qty { get; set; }
        [DataMember]
        public string BeginTime { get; set; }
        [DataMember]
        public string EndTime { get; set; }
        [DataMember]
        public string UseInfo { get; set; }
        [DataMember]
        public string BuyType { get; set; }
        [DataMember]
        public string CouponUrl { get; set; }
        [DataMember]
        public string OffersTips { get; set; }
        [DataMember]
        public string IsOnline { get; set; }
        [DataMember]
        public string Price { get; set; }
        [DataMember]
        public string SalesPrice { get; set; }
        [DataMember]
        public string DiscountRate { get; set; }
        [DataMember]
        public string Integral { get; set; }
        [DataMember]
        public string BrandId { get; set; }
        [DataMember]
        public string IsIAlumniItem { get; set; }
        [DataMember]
        public string IsExchange { get; set; }
        [DataMember]
        public string IntegralExchange { get; set; }
        [DataMember]
        public string ItemCategoryName { get; set; }
        [DataMember]
        public string SkuId { get; set; }
        [DataMember]
        public string Prop1Name { get; set; }
        [DataMember]
        public string Prop2Name { get; set; }
        [DataMember]
        public string Prop3Name { get; set; }
        [DataMember]
        public string Prop2DetailName { get; set; }
        [DataMember]
        public string SkuPropId3 { get; set; }
        [DataMember]
        public string ItemDisplayIndex { get; set; }
        [DataMember]
        public string ItemTypeDesc { get; set; }
        [DataMember]
        public string ItemSortDesc { get; set; }
        [DataMember]
        public string SalesQty { get; set; }
        [DataMember]
        public string ForPoints { get; set; }
        [DataMember]
        public string IsEveryoneSales { get; set; }
        [DataMember]
        public string EveryoneSalesPrice { get; set; }
        [DataMember]
        public string ReturnAmount { get; set; }
        [DataMember]
        public string ItemIntroduce { get; set; }
        [DataMember]
        public string ItemParaIntroduce { get; set; }
        [DataMember]
        public string ScanCodeIntegral { get; set; }
        [DataMember]
        public string EdProp { get; set; }
        [DataMember]
        public string FactoryName { get; set; }
        [DataMember]
        public string Gg { get; set; }
        [DataMember]
        public string Degree { get; set; }
        [DataMember]
        public string RoomImg { get; set; }
        [DataMember]
        public string RoomDesc { get; set; }
    }
}
