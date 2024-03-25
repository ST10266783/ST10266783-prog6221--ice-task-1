// ShoppingCart.cs

using System;

namespace ShoppingCartApp
{
    public class ShoppingCart
    {
        // Fields
        private Product[] products;
        private int itemCount;

        // Properties
        public Product[] Products { get { return products; } }
        public int ItemCount { get { return itemCount; } }

        // Constructor
        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
            itemCount = 0;
        }

        // Method to add a product to the shopping cart
        public void AddProduct(Product product)
        {
            if (itemCount < products.Length)
            {
                products[itemCount] = product;
                itemCount++;
                Console.WriteLine($"Added '{product.Name}' to the cart.");
            }
            else
            {
                Console.WriteLine("The shopping cart is full.");
            }
        }
        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (products[i] == product)
                {
                    // Shift elements to the left to fill the gap
                    for (int j = i; j < itemCount - 1; j++)
                    {
                        products[j] = products[j + 1];
                    }
                    products[itemCount - 1] = null; // Remove reference from last element
                    itemCount--;
                    Console.WriteLine($"Removed '{product.Name}' from the cart.");
                    return;
                }
            }
            Console.WriteLine("Product not found in the cart.");
        }
    }
}



