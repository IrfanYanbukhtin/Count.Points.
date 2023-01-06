using System;

namespace _06._01._23.lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ballari daxil edin:");
            int[] R = new int[3];
            int[] A = new int[3];
            int Resad = 0;
            int Aydan = 0;

            for (int i = 0; i < R.Length; i++)
            {
                Console.WriteLine($"Points (R) [{i+1}]");
                R[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine($"Points (A)  [{i+1}]");
                    A[i] = int.Parse(Console.ReadLine());
                }

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > R[i])
                {
                    Aydan++;
                }

                if (R[i] > A[i])
                {
                    Resad++;
                }

            }
            Console.WriteLine($"{Resad} : {Aydan}");
        }
    }
}
