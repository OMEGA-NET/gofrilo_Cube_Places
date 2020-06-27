using Jobs.Models.Emun;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobs.Models
{
   public class Product
    {
        public string _id { get; set; }
        public Guid code { get; set; }
        public string name { get; set; }
        public TipoProducto type { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public string picture { get; set; }
    }
}
