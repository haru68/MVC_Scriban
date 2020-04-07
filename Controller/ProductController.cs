using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelViewController_Scriban.Model;

namespace ModelViewController_Scriban.Controller
{
    public class ProductController
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            using(var context = new ProductContext())
            {
                products = (from p in context.Products
                            orderby p.Name
                            select p).Distinct().ToList();
            }
            return products;
        }
    }
}
