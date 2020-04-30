using System;

namespace PRG2_20192_P1_3_08
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Masukkan berapa anak ayam : ");
            int N = Convert.ToInt16(Console.ReadLine());
            
            for(int a = N; a>=1 ;a--)
            {
                if (a == 1)
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal induknya", a);
                }
                else
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {1}", a, a - 1);
                }
            }
        }
    }
}
