using System;

class SearchProduct
{
    public static int LinearSearch(string[] products, string target)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i] == target)
                return i;
        }
        return -1;
    }
}
