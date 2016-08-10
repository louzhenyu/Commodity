using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ZMind.Commodity.DTO.Request
{
    [DataContract]
    public class RequestCommodity
    {
        [DataMember]
        public string ItemId { get; set; }
        [DataMember]
        public string ItemCategoryId { get; set; }
        [DataMember]
        public string ItemName { get; set; }
        [DataMember]
        //是否模糊查询
        public bool IsFuzzy { get; set; }
        [DataMember]
        public string CustomerId { get; set; }
        [DataMember]
        public List<ColumnOrder> OrderBy { get; set; }
        [DataMember]
        public int PageIndex { get; set; }
        [DataMember]
        public int PageSize { get; set; }
    }
    [DataContract]
    public class ColumnOrder
    {
        [DataMember]
        public string ColumnName { get; set; }
        [DataMember]
        public bool IsAsc { get; set; }
    }
}
