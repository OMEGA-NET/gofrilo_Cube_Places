using Jobs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.Data.Contracts
{
   public interface IDataOriginRepository
    {
        Task<List<Product>> ReadProductsFromJson();
        Task<List<Product>> ReadProductsFromText();
        Task<List<Product>> ReadProductsFromSqlLite();
    }
}
