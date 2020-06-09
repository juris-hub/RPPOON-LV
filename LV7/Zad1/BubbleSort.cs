using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            for (int p = 0; p <= array.Length - 2; p++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {

                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
        }
    }
}
