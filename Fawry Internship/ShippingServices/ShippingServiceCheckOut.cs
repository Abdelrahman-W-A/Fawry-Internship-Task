using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fawry_Internship.Carts;
using Fawry_Internship.Customers;

namespace Fawry_Internship.ShippingService
{
    public class CheckOuts
    {
        #region Methods

        public static void CheckOut(Customer customer, Cart cart)
        {
            if (customer == null || cart == null)
            {
                Console.WriteLine("Invalid customer or cart.");
                return;
            }
            
            Console.WriteLine("** Shipping notice **");

            decimal TotalsWeight = 0;
            foreach (var item in cart.items)
            {
                if (item.Product == null)
                {
                    Console.WriteLine("No product in cart.");
                    continue;
                }

                Console.Write($"{item.Quantity}x {item.Product.Name}");     Console.WriteLine($"    {item.Product.Weight}");
                decimal TotalWeight = item.Product.Weight*item.Quantity;
                TotalsWeight = (TotalWeight + TotalWeight);
            }
            

                Console.WriteLine($"Total Package Weight {TotalsWeight / 1000}Kg");
                Console.WriteLine();
                Console.WriteLine("** Checkout receipt **");
            decimal Subtotal = 0;
            foreach (var item in cart.items)
            {
                decimal TotalPrice = item.Product.Price * item.Quantity;
                Console.WriteLine($"{item.Quantity}x {item.Product.Name}        {TotalPrice}");

                Subtotal = Subtotal + TotalPrice;
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"SubTotal        {Subtotal}");
            Console.WriteLine($"Shipping        {15*(cart.items.Count)}");
            Console.WriteLine($"Amount          {Subtotal + (15 * (cart.items.Count))}");
        }
        #endregion
    }
}
