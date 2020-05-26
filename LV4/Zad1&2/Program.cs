using System;

namespace Lv4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Dataset data = new Dataset("csvdat.csv");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);


            double[] cols = adapter.CalculateAveragePerColumn(data);
            double[] rows = adapter.CalculateAveragePerRow(data);


            foreach (double number in rows)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(" ");

            foreach (double number1 in cols)
            {
                Console.WriteLine(number1);
            }


        }
    }

}
