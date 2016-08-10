using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SolrNet;
using SolrNet.Commands.Parameters;
using ZMind.Commodity.ConfigHelper;
using ZMind.Commodity.DomainEntity;
using ZMind.Commodity.DTO.Request;
using ZMind.Commodity.DTO.Response;

namespace ZMind.Commodity.Application
{
    public class CommodityApplication
    {
        public CommodityApplication()
        {
            AutoMapperConfig.Initialize();
        }

        private readonly ISolrOperations<CommoditySolr> _solr = ConnMgr<CommoditySolr>.GetInstance();

        public ResponseCommodity GetCommodity(RequestCommodity request)
        {
            var result = new ResponseCommodity();
            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(request.ItemName))
            {
                if (request.IsFuzzy)
                {
                    sb.Append("item_name:" + request.ItemName);
                }
                else
                {
                    sb.Append("item_name:\"" + request.ItemName + "\"");
                }
            }

            if (!string.IsNullOrWhiteSpace(request.ItemId))
            {
                if (sb.Length > 0)
                {
                    sb.Append(" && item_id:\"" + request.ItemId + "\"");
                }
                else
                {
                    sb.Append("item_id:\"" + request.ItemId + "\"");                 
                }
            }

            if (!string.IsNullOrWhiteSpace(request.ItemCategoryId))
            {
                if (sb.Length > 0)
                {
                    sb.Append(" && item_category_id:\"" + request.ItemCategoryId + "\"");
                }
                else
                {
                    sb.Append("item_category_id:\"" + request.ItemCategoryId + "\"");
                }
            }
            if (!string.IsNullOrWhiteSpace(request.CustomerId))
            {
                if (sb.Length > 0)
                {
                    sb.Append(" && CustomerId:\"" + request.CustomerId + "\"");
                }
                else
                {
                    sb.Append("CustomerId:\"" + request.CustomerId + "\"");
                }
            }
            if (sb.Length == 0)
            {
                result.IsSuccess = false;
                result.ErrorMessage = "没有查询参数";
                return result;
            }
            var sortOrders = request.OrderBy.Select(i => new SortOrder(i.ColumnName, i.IsAsc ? Order.ASC : Order.DESC)).ToArray();
            var commoditySolr = _solr.Query(new SolrQuery(sb.ToString()), new QueryOptions
            {
                OrderBy = sortOrders,
                Start = request.PageIndex,
                Rows = request.PageSize
            });
            result.IsSuccess = true;
            result.TotalCount = commoditySolr.NumFound;
            result.ResponseCommodityDetailList = new List<DTO.Response.Commodity>();
            foreach (var i in commoditySolr)
            {
                result.ResponseCommodityDetailList.Add(Mapper.Map<DTO.Response.Commodity>(i));
            }
            return result;
        }
    }
}
