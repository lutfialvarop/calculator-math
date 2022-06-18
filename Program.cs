using System;

namespace BelajarCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, c;
            string b, d;
            char ulang = 'y';

            while (ulang == 'y') { 
                Console.Write("Maukan Angka Pertama : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Masukan Operasi(+, -, *, /, %) : ");
                b = Console.ReadLine();
                Console.Write("Maukan Angka Ke Dua : ");
                c = int.Parse(Console.ReadLine());
                Console.Write("\n");


                if (b == "+")
                {
                    d = Convert.ToString(a + c);
                    Console.WriteLine($"Hasil : {d}");
                } else if (b == "-")
                {
                    d = Convert.ToString(a - c);
                    Console.WriteLine($"Hasil : {d}");
                } else if (b == "*")
                {
                    d = Convert.ToString(a * c);
                    Console.WriteLine($"Hasil : {d}");
                } else if (b == "/")
                {
                    d = Convert.ToString(a / c);
                    Console.WriteLine($"Hasil : {d}");
                } else if (b == "%")
                {
                    d = Convert.ToString(a % c);
                    Console.WriteLine($"Hasil : {d}");
                } else
                {
                    Console.WriteLine("Yang Anda Masukan Bukan Angka/Operasi Yang Anda Maukan Salah !!!");
                }

                Console.Write("\n\n");
                Console.Write("Ulangi(y / n) : ");
                ulang = Convert.ToChar(Console.ReadLine());
                Console.Write("\n\n");
            }

            Console.ReadKey();
        }
    }
}
