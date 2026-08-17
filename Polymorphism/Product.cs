using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        public override bool Equals(object product)
        {
            Product other = product as Product;

            return other.ProductId == this.ProductId && other.ProductName == this.ProductName && other.ProductPrice == this.ProductPrice;
          
        }
    }
}
