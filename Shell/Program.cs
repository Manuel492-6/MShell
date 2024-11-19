﻿namespace Shell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p;
            int[] Arreglo = { 9, 1, 4, 2, 8, 7, 3, 6, 5 };
            Shell(Arreglo, Arreglo.Length);
            for (p = 0; p < Arreglo.Length; p++)
            {
                Console.WriteLine(Arreglo[p]);
            }
        }

        static void Shell(int[] A, int n)
        {
            int Salto = n + 1;

            while (Salto > 1)
            {
                Salto = Salto / 2;
                int Band = 1;
                while (Band == 1)
                {
                    Band = 0;
                    int I = 0;

                    while ((I + Salto) < n)
                    {
                        if (A[I] > A[I + Salto])
                        {
                            int X = A[I];
                            A[I] = A[I + Salto];
                            A[I + Salto] = X;
                            Band = 1;
                        }
                        else
                        {
                            I = I + 1;
                        }
                    }
                }
            }
        }
    }
}