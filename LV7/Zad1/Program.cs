using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            CombSort combSort = new CombSort();
            BubbleSort bubbleSort = new BubbleSort();
            SequentialSort sequentialSort = new SequentialSort();
            double[] array = { 9.2, 3.3, 11.2, 10.1, 21, 3, 28.2, 84.3 };

            Console.WriteLine("CombSort:");
            NumberSequence numberSequence2 = new NumberSequence(array);
            numberSequence2.SetSortStrategy(combSort);
            Console.WriteLine("Prije: \n" + numberSequence2.ToString());
            numberSequence2.Sort();
            Console.WriteLine("Poslije: \n" + numberSequence2.ToString());

            Console.WriteLine("BubbleSort:");
            NumberSequence numberSequence1 = new NumberSequence(array);
            numberSequence1.SetSortStrategy(bubbleSort);
            Console.WriteLine("Prije: \n" + numberSequence1.ToString());
            numberSequence1.Sort();
            Console.WriteLine("Poslije: \n" + numberSequence1.ToString());

            Console.WriteLine("SequentialSort:");
            NumberSequence numberSequence3 = new NumberSequence(array);
            numberSequence3.SetSortStrategy(sequentialSort);
            Console.WriteLine("Prije: \n" + numberSequence3.ToString());
            numberSequence3.Sort();
            Console.WriteLine("Poslije: \n" + numberSequence3.ToString());
        }
    }
}
