using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fawry_Internship.Products;

namespace Fawry_Internship.Carts
{
    public class CartNormalItems
    {
        #region Properties
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        #endregion

        #region Constructor
        public CartNormalItems(Product product, int Quantityy)
        {
            this.Product = product;
            this.Quantity = Quantityy;
        }
        #endregion
    }
}
