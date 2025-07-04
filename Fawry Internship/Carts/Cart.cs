using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fawry_Internship.Products;

namespace Fawry_Internship.Carts
{
    public class Cart
    {
        #region Properties
        public List<CartItems> items = new();
        public List<CartNormalItems> NormalItems = new();
        #endregion

        #region Methods
        public void Add(ShippedProduct product, int quantity)
        {
            if (quantity <= product.Quantity)
                items.Add(new CartItems(product, quantity));
        }

        public void Add(Product product, int quantity)
        {
            if (quantity <= product.Quantity)
                NormalItems.Add(new CartNormalItems(product, quantity));
        }
        #endregion
    }
}
