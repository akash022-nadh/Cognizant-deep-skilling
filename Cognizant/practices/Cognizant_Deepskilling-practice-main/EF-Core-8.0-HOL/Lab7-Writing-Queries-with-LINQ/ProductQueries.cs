using System.Collections.Generic;
using System.Linq;

public class ProductQueries
{
    public List<Product> GetExpensiveProducts(List<Product> products)
    {
        return products
            .Where(p => p.Price > 1000)
            .ToList();
    }
}
