using System.Collections.Generic;
using MVC.Models;

namespace MVC
{
    public static class ProductList
    {
        private static List<Product> _products = new List<Product>
    {
        new Product {Name = "Margherita", Price = 210},
        new Product {Name = "Hawaiian", Price = 180},
        new Product {Name = "Pepperoni ", Price = 190},
        new Product {Name = "Vegetarian ", Price = 240},
        new Product {Name = "BBQ Chicken ", Price = 230},

    };

        public static IReadOnlyList<Product> Products => _products.AsReadOnly();
    }
}
