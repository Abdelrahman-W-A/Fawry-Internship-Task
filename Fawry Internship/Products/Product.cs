using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Internship.Products
{
    public class Product
    {
        #region Properties
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsExpired { get; set; }
        #endregion

        #region Constructors
        public Product(string name, decimal price, int Quantity,bool IsExpired)
        {
            Name = name;
            Price = price;
            this.Quantity = Quantity;
            this.IsExpired = IsExpired;
        }
        #endregion
    }
}
