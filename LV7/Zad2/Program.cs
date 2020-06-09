using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 21, 9.2, 2, 11, 55, 34, 5.6, 652, 4.6, 32 };
            NumberSequence numberSequence = new NumberSequence(array);
            LinearSearch linearSearch = new LinearSearch();
            numberSequence.SetSearchStrategy(linearSearch);
            int index = numberSequence.Search(552);
            if (index >= 0)
                Console.WriteLine("Pronađen na : " + index);
            else
                Console.WriteLine("Nije pronaden !");
        }
    }
}
