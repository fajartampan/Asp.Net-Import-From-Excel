using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImportExcelToMySQL.Models
{
    public class Product
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }

    }
}