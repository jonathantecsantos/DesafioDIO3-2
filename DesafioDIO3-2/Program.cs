using System;

namespace DesafioDIO3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int V = int.Parse(Console.ReadLine());
            while (V > 50)
            {
                V = int.Parse(Console.ReadLine());
            }
            int[] N = new int[10];
            if (V <= 50)
            {
                N[0] = V;
            }

            int cont = 1;

            for (int i = 0; i < N.Length - 1; i++)
            {
                N[i + cont] += N[i] * 2;
            }
            for (int j = 0; j < N.Length; j++)
            {
                Console.WriteLine($"N[{j}] = " + N[j]);
            }

        }
    }
}
