using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Lambda_Expressions.RealTime_Lambda_Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>
                {
                    new Product { Id = 1, Name = "Laptop", Price = 50000 },
                    new Product { Id = 2, Name = "Mouse", Price = 800 },
                    new Product { Id = 3, Name = "Keyboard", Price = 1500 }
                };

            var result = products.Where(product => product.Price > 1000);

            foreach (Product product in result)
            {
                Console.WriteLine(product.Name + " : " + product.Price);
            }
        }
    }
}