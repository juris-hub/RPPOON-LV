using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset data1 = new Dataset("csv.csv");
            Dataset data2 = (Dataset)data1.Clone();

            data1.Print();
            data2.Change("change");
            data2.Print();
            data1.ClearData();

            data1.Print();
            data2.Print();
        }


    }
}
