using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDoperationmvc.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}