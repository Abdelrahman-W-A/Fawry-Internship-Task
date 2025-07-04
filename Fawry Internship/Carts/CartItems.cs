using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fawry_Internship.Products;

namespace Fawry_Internship.Carts
{
    public class CartItems
    {
        #region Properties
        public ShippedProduct? Product { get; set; }
        public int Quantity { get; set; }
        #endregion

        #region Constructor
        public CartItems(ShippedProduct product, int Quantity)
        {
            this.Product = product;
            this.Quantity = Quantity;
        }


        #endregion

    }
}
