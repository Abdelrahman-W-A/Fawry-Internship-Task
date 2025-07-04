using Fawry_Internship.Carts;
using Fawry_Internship.Customers;
using Fawry_Internship.Products;
using Fawry_Internship.ShippingService;

namespace Fawry_Internship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippedProduct Cheese = new ShippedProduct("Cheese", 100M, 2, true, 400);
            ShippedProduct biscuits = new ShippedProduct("Biscuits", 150, 1, true, 700);
            Product tv = new Product("TV", 300, 1, false);
            Product ScratchCard = new Product("ScratchCard", 100, 1, false);

            var customer = new Customer("Abdelrahman", 1000);
            var cart = new Cart();

            cart.Add(Cheese, 2);
            cart.Add(biscuits, 1);
            cart.Add(tv, 3);
            cart.Add(ScratchCard, 1);

            CheckOuts.CheckOut(customer, cart);
            
        }
    }
}
