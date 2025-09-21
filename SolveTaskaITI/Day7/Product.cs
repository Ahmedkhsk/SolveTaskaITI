using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTaskaITI.Day7
{
    public class Product
    {
        public string Name { get; set; } = default!;
        public double Price { get; set; }

        public static Product CreateProduct()
        {
            return new Product { Name = "Laptop", Price = 1200.50 };
        }
    }
}
