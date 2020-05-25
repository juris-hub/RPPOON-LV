using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class RandomGenerator
    {

        private static RandomGenerator instance;
        private Random generator;
        private RandomGenerator()
        {
            this.generator = new Random();
        }
        public static RandomGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomGenerator();
            }
            return instance;
        }


        public double[][] NextMatrix(int redovi, int stupci)
        {
            double[][] matrica = new double[redovi][];
            for (int i = 0; i < redovi; i++)
            {
                matrica[i] = new double[stupci];
            }
            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < redovi; j++)
                {
                    matrica[i][j] = this.generator.NextDouble();
                }
            }
            return matrica;
        }

    }

}
