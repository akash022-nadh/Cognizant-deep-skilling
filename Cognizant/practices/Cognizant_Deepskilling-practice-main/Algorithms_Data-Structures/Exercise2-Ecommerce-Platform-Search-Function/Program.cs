using System;

class Program
{
    static void Main()
    {
        string[] products = { "Laptop", "Mobile", "Headphones", "Keyboard" };

        int result = SearchProduct.LinearSearch(products, "Mobile");

        if (result != -1)
            Console.WriteLine("Product found at index: " + result);
        else
            Console.WriteLine("Product not found");
    }
}
