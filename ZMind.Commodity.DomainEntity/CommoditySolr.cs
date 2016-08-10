using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolrNet.Attributes;

namespace ZMind.Commodity.DomainEntity
{
    public class CommoditySolr
    {
        [SolrUniqueKey("item_id")]
        public string ItemId { get; set; }
        [SolrField("item_category_id")]
        public string ItemCategoryId { get; set; }
        [SolrField("item_code")]
        public string ItemCode { get; set; }
        [SolrField("item_name")]
        public string ItemName { get; set; }
        [SolrField("item_name_en")]
        public string ItemNameEn { get; set; }
        [SolrField("item_name_short")]
        public string ItemNameShort { get; set; }
        [SolrField("pyzjm")]
        public string Pyzjm { get; set; }
        [SolrField("item_remark")]
        public string ItemRemark { get; set; }
        [SolrField("status")]
        public string Status { get; set; }
        [SolrField("status_desc")]
        public string StatusDesc { get; set; }
        [SolrField("create_user_id")]
        public string CreateUserId { get; set; }
        [SolrField("create_time")]
        public string CreateTime { get; set; }
        [SolrField("modify_user_id")]
        public string ModifyUserId { get; set; }
        [SolrField("modify_time")]
        public string ModifyTime { get; set; }
        [SolrField("bat_id")]
        public string BatId { get; set; }
        [SolrField("if_flag")]
        public string IfFlag { get; set; }
        [SolrField("ifgifts")]
        public string IfGifts { get; set; }
        [SolrField("ifofen")]
        public string IfOften { get; set; }
        [SolrField("ifservice")]
        public string IfService { get; set; }
        [SolrField("IsGB")]
        public string IsGb { get; set; }
        [SolrField("data_from")]
        public string DataFrom { get; set; }
        [SolrField("display_index")]
        public string DisplayIndex { get; set; }
        [SolrField("imageUrl")]
        public string ImageUrl { get; set; }
        [SolrField("imageUrlFirst")]
        public string ImageUrlFirst { get; set; }
        [SolrField("imageUrl2")]
        public string ImageUrl2 { get; set; }
        [SolrField("imageUrl3")]
        public string ImageUrl3 { get; set; }
        [SolrField("CustomerId")]
        public string CustomerId { get; set; }
        [SolrField("PTypeId")]
        public string PTypeId { get; set; }
        [SolrField("PTypeCode")]
        public string PTypeCode { get; set; }
        [SolrField("Tel")]
        public string Tel { get; set; }
        [SolrField("ItemUnit")]
        public string ItemUnit { get; set; }
        [SolrField("Qty")]
        public string Qty { get; set; }
        [SolrField("BeginTime")]
        public string BeginTime { get; set; }
        [SolrField("EndTime")]
        public string EndTime { get; set; }
        [SolrField("UseInfo")]
        public string UseInfo { get; set; }
        [SolrField("BuyType")]
        public string BuyType { get; set; }
        [SolrField("CouponURL")]
        public string CouponUrl { get; set; }
        [SolrField("OffersTips")]
        public string OffersTips { get; set; }
        [SolrField("IsOnline")]
        public string IsOnline { get; set; }
        [SolrField("Price")]
        public string Price { get; set; }
        [SolrField("SalesPrice")]
        public string SalesPrice { get; set; }
        [SolrField("DiscountRate")]
        public string DiscountRate { get; set; }
        [SolrField("Integral")]
        public string Integral { get; set; }
        [SolrField("BrandId")]
        public string BrandId { get; set; }
        [SolrField("IsIAlumniItem")]
        public string IsIAlumniItem { get; set; }
        [SolrField("IsExchange")]
        public string IsExchange { get; set; }
        [SolrField("IntegralExchange")]
        public string IntegralExchange { get; set; }
        [SolrField("ItemCategoryName")]
        public string ItemCategoryName { get; set; }
        [SolrField("SkuId")]
        public string SkuId { get; set; }
        [SolrField("Prop1Name")]
        public string Prop1Name { get; set; }
        [SolrField("Prop2Name")]
        public string Prop2Name { get; set; }
        [SolrField("Prop3Name")]
        public string Prop3Name { get; set; }
        [SolrField("prop_2_detail_name")]
        public string Prop2DetailName { get; set; }
        [SolrField("sku_prop_id3")]
        public string SkuPropId3 { get; set; }
        [SolrField("ItemDisplayIndex")]
        public string ItemDisplayIndex { get; set; }
        [SolrField("ItemTypeDesc")]
        public string ItemTypeDesc { get; set; }
        [SolrField("ItemSortDesc")]
        public string ItemSortDesc { get; set; }
        [SolrField("salesQty")]
        public string SalesQty { get; set; }
        [SolrField("Forpoints")]
        public string ForPoints { get; set; }
        [SolrField("IsEveryoneSales")]
        public string IsEveryoneSales { get; set; }
        [SolrField("EveryoneSalesPrice")]
        public string EveryoneSalesPrice { get; set; }
        [SolrField("ReturnAmount")]
        public string ReturnAmount { get; set; }
        [SolrField("ItemIntroduce")]
        public string ItemIntroduce { get; set; }
        [SolrField("ItemParaIntroduce")]
        public string ItemParaIntroduce { get; set; }
        [SolrField("ScanCodeIntegral")]
        public string ScanCodeIntegral { get; set; }
        [SolrField("EdProp")]
        public string EdProp { get; set; }
        [SolrField("FactoryName")]
        public string FactoryName { get; set; }
        [SolrField("GG")]
        public string Gg { get; set; }
        [SolrField("Degree")]
        public string Degree { get; set; }
        [SolrField("RoomImg")]
        public string RoomImg { get; set; }
        [SolrField("RoomDesc")]
        public string RoomDesc { get; set; }
    }
}
