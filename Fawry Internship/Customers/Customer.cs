using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Internship.Customers
{
    public class Customer
    {
        #region Properties
        public string? Name { get; set; }
        public decimal? balance { get; set; }
        #endregion

        #region Constructors
        public Customer(string Name,decimal balance)
        {
            this.Name = Name;
            this.balance = balance;
        }
        #endregion
    }
}
