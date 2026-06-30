using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Anonymous_Types.RealTime_Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product[] products =
            {
                new Product { Id = 1, Name = "Laptop", Price = 50000 },
                new Product { Id = 2, Name = "Mouse", Price = 800 }
            };

            var result =
                products.Select(product => new
                {
                    product.Name,
                    product.Price
                });

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }
        }
    }
}