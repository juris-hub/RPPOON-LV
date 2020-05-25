using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[][] matrica = new double[5][];
            for (int i = 0; i < 5; i++)
            {
                matrica[i] = new double[3];
            }
            RandomGenerator matrixgen = RandomGenerator.GetInstance();
            matrica = matrixgen.NextMatrix(5, 5);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrica[i][j].ToString() + '\t');
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

    }

}
