using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Jobs.Data.Contracts;
using Jobs.Models;

namespace Jobs.Data.Repository
{
    public class DataOriginSqlLiteRepository : IDataOriginRepository
    {
        public Task<List<Product>> ReadProducts()
        {
            //lear....
            throw new NotImplementedException();
        }
    }
}
