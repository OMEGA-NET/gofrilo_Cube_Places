using Jobs.Data.Contracts;
using Jobs.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jobs.Data.Repository
{
    public class DataOriginRepository : IDataOriginRepository
    {
        public async Task<List<Product>> ReadProductsFromJson()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            var jsonString = await File.ReadAllTextAsync("../Jobs.Data/DataOrigin/dbJobs.json");
            var jsonModel = JsonSerializer.Deserialize<List<Product>>(jsonString, options);

            return jsonModel;
        }

        public Task<List<Product>> ReadProductsFromSqlLite()
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> ReadProductsFromText()
        {
            throw new NotImplementedException();
        }
    }
}
