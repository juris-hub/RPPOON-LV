using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box("shoplist");
            Product product1 = new Product("Papuce", 200, 9);
            Product product2 = new Product("Muhalica", 3000, 23);
            box.Add(product1);
            box.Add(product2);


            ShippingService price = new ShippingService(5);
            double weight = box.Weight;


            Console.WriteLine(price.ToString() + price.Price(weight) + " HRK");
        }
    }
}
