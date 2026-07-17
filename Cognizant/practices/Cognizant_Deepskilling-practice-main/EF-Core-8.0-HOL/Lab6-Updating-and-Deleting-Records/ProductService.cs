using System.Collections.Generic;
using System.Linq;

public class ProductService
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void UpdateProduct(int id, string newName)
    {
        Product product = products.FirstOrDefault(p => p.ProductId == id);

        if (product != null)
        {
            product.ProductName = newName;
        }
    }

    public void DeleteProduct(int id)
    {
        Product product = products.FirstOrDefault(p => p.ProductId == id);

        if (product != null)
        {
            products.Remove(product);
        }
    }
}
