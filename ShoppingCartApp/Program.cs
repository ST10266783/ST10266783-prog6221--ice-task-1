using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the shopping cart
            ShoppingCart cart = new ShoppingCart(5);

            // Adding products to the cart
            ClothingProduct shirt = new ClothingProduct("T-Shirt", 15.99, ProductCategory.Clothing, "M", "Red");
            ElectronicsProduct phone = new ElectronicsProduct("Smartphone", 599.99, ProductCategory.Electronics, "Samsung", "Galaxy S20");

            cart.AddProduct(shirt);
            cart.AddProduct(phone);

            // Displaying cart contents
            Console.WriteLine("\nCart Contents:");
            foreach (Product product in cart.Products)
            {
                if (product != null)
                {
                    product.GetInfo();
                }
            }

            // Removing a product from the cart
            cart.RemoveProduct(shirt);

            // Displaying updated cart contents
            Console.WriteLine("\nUpdated Cart Contents:");
            foreach (Product product in cart.Products)
            {
                if (product != null)
                {
                    product.GetInfo();
                }
            }
        }
    }
}
