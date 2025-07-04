using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Internship.Products
{
    public class ShippedProduct : Product
    {
        #region Properties
        public new decimal Weight { get; set; }
        #endregion

        #region Constructors
        public ShippedProduct(string Name, decimal price, int quantity, bool IsExpired,  decimal Weight) : base(Name, price, quantity, IsExpired)
        {
            this.Weight = Weight;
        }
        #endregion

    }
}
