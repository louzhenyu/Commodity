using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Practices.ServiceLocation;
using SolrNet;
using ZMind.Commodity.DomainEntity;

namespace ZMind.Commodity.ConfigHelper
{
    public static class ConfigHelper
    {
        private static string _solrUrl;

        public static string SolrUrl
        {
            get
            {
                if (string.IsNullOrEmpty(_solrUrl))
                {
                    _solrUrl = ConfigurationManager.AppSettings["SolrURL"];
                }
                return _solrUrl;
            }
        }
    }

    public static class ConnMgr<T>
    {
        static ConnMgr()
        {
            Startup.Init<T>(ConfigHelper.SolrUrl);
        }

        public static ISolrOperations<T> GetInstance()
        {
            var instance = ServiceLocator.Current.GetInstance<ISolrOperations<T>>();
            if (instance == null)
            {
                Startup.Init<T>(ConfigHelper.SolrUrl);
                instance = ServiceLocator.Current.GetInstance<ISolrOperations<T>>();
            }
            return instance;
        }
    }

    public static class AutoMapperConfig
    {
        static AutoMapperConfig()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CommoditySolr, DTO.Response.Commodity>());
        }

        public static void Initialize()
        {
        }
    }
}
