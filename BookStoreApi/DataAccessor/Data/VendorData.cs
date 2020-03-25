using DataAccessor.Common;
using DataAccessor.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataAccessor.Data
{
    public class VendorData
    {
        private static volatile VendorData instance;
        private static readonly object syncRoot = new object();
        private static IConfiguration configuration { get; set; }
        private IEnumerable<Vendor> _vendorData { get; set; }
        private VendorData()
        {
            configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("DataJsonFile/DeliveryVendorData.json", optional: false)
            .Build();
        }

        public static VendorData Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new VendorData();
                    }
                }
                return instance;
            }
        }
        public IEnumerable<Vendor> Vendors
        {
            get
            {
                if (_vendorData == null || !_vendorData.Any())
                {
                    var data = new List<Vendor> 
                    { 
                        MappingVendorFromJson("DeliveryVendor:Motorbike", "Motorbike"),
                        MappingVendorFromJson("DeliveryVendor:Train", "Train"),
                        MappingVendorFromJson("DeliveryVendor:Aircraft", "Aircraft"),
                    };
                    _vendorData = data;
                }
                return _vendorData;
            }
        }
        private Vendor MappingVendorFromJson(string key, string name)
        {
            var data = configuration.GetSection(key).GetChildren().ToArray();
            var factorsForMonth = configuration.GetSection($"{key}:FactorsForMonth").GetChildren().ToDictionary(x => x.Key, x => float.Parse(x.Value));
            var result = new Vendor
            {
                Id = int.Parse(data.FirstOrDefault(x=>x.Key == nameof(Vendor.Id)).Value),
                BaseCost = double.Parse(data.FirstOrDefault(x=>x.Key == nameof(Vendor.BaseCost)).Value),
                Name = name,
                ServiceType = (ServiceType) Enum.Parse(typeof(ServiceType), data.FirstOrDefault(x => x.Key == nameof(Vendor.ServiceType)).Value),
                FactorsForMonth = factorsForMonth
            };
            return result;
        }
    }
}
