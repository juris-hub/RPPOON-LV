using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2
{
    class LinearSearch : SearchStrategy
    {
        public override int Search(double[] array, double Number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == Number)
                    return i;
            }
            return -1;
        }
    }
}
