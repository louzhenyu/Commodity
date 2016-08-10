using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZMind.Commodity.Test.CommodityServiceReference;

namespace ZMind.Commodity.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var commodityService = new CommodityServiceClient();
            var request = new RequestCommodity
            {
                ItemName = "鱼",
                IsFuzzy = true,
                PageIndex = 0,
                PageSize = 20,
                OrderBy = new[]
                {
                    new ColumnOrder
                    {
                        ColumnName = "create_time",
                        IsAsc = true
                    },
                    new ColumnOrder
                    {
                        ColumnName = "item_code",
                        IsAsc = false
                    }
                }
            };
            
            var result = commodityService.GetCommodity(request);
            Console.Write("执行成功:{0}\n错误消息:{1}\n结果数:{2}",result.IsSuccess, result.ErrorMessage, result.TotalCount);
            Console.ReadKey();
        }
    }
}
