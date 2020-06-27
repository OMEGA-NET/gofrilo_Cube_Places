using Jobs.Data.Contracts;
using Jobs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Jobs.Data.Repository
{
    public class DataOriginExcelRepository : IDataOriginRepository
    {
        public Task<List<Product>> ReadProducts()
        {
            throw new NotImplementedException();
        }
    }
}
