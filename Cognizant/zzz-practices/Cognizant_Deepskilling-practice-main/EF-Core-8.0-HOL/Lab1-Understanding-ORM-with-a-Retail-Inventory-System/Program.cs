using System;

class Program
{
    static void Main()
    {
        Product product = new Product
        {
            ProductId = 1,
            ProductName = "Laptop",
            Price = 50000
        };

        Console.WriteLine("Product ID: " + product.ProductId);
        Console.WriteLine("Product Name: " + product.ProductName);
        Console.WriteLine("Price: " + product.Price);
    }
}
