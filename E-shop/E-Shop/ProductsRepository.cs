using E_Shop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop
{
    public class ProductsRepository
    {
        private readonly List<Product> _products = new List<Product>()
        {
                new Product(1,"Zlaten dab",0.5,100,42),
                new Product(2,"Zlaten dab",1.5,100,97),
                new Product(3,"Krali Marko",1.5,100,75),
                new Product(4,"Krali Marko-glass",0.5,100,37),
                new Product(5,"Skopsko",0.5,100,45),
                new Product(6,"Skopsko",1.5,50,105),
        };

        public List<string> GetAllVendors()
        {
            return _products.Select(x => x.Name).ToList();
        }

        public List<Product> GetProductByName(string name)
        {
            return _products.Where(x => x.Name.Contains(name)).ToList();
        }
    }
}
