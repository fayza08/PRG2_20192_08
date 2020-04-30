using System;

namespace PRG2_20192_P1_4_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.Write("1. Hitung Luas \n2. Hitung Hipotenusa \n3. Hitung Keliling\n4. Keluar\n");
            Console.WriteLine("Masukkan Menu : ");
            int m = Convert.ToInt16(Console.ReadLine());

            switch (m)
            {
                case 1: luas();break;
                case 2: hipo();break;
                case 3: keliling();break;
                case 4: break;     
                    
            }
            
        }

        static void luas()
        {
            Console.Write("\nMasukkan alas : ");
            double a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan tinggi : ");
            double t = Convert.ToInt16(Console.ReadLine());
            double L = 0.5 * a * t;
            Console.WriteLine("\nLuas Segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", a, t, L);
        }

        static double hipo()
        {
            Console.Write("\nMasukkan alas : ");
            double a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan tinggi : ");
            double t = Convert.ToInt16(Console.ReadLine());
            double h = Math.Sqrt((a * a) + (t * t));
            Console.Write("\nPanjang Hipotenusa : {0}", h);
            return h;
        }

        static void keliling()
        {
            Console.Write("\nMasukkan alas : ");
            double a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Masukkan tinggi : ");
            double t = Convert.ToInt16(Console.ReadLine());
            double h = Math.Sqrt((a * a) + (t * t));
            double k = a + t + h;
            Console.Write("Keliling segitiga = {0}", k);
            }
        }
 }
   
