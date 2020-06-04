using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class ShippingService
    {
        private double cost;

        public ShippingService(double cost) { this.cost = cost; }

        public double Price(double weight)
        {
            return weight * cost;
        }

        public override string ToString()
        {
            return "Cijena vašeg paketa je:";
        }
    }
}
