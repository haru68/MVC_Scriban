using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController_Scriban.Model
{
    class ProductPopulator
    {
        public void Populate(int numberOfProducts)
        {
            Random randomGenerator = new Random();
            using(var context = new ProductContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                for(int i = 0; i<numberOfProducts; i++)
                {
                    Product product = new Product();
                    product.Name = "product n° " + i;
                    product.Price = randomGenerator.Next(0, 1000);
                    context.Add(product);
                }
                context.SaveChanges();
            }
        }
    }
}
