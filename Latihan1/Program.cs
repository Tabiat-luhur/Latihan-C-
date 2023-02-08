using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            char c;
            Console.WriteLine(" > > > Kalkulator Console < < <");
            Console.Write(" > Masukan Angka Pertama : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" > Masukan Angka Kedua : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" > Masukan Operasi Perhitungan [ + / - / : / * ] : ");
            c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine(" > Hasil " + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case '-':
                    Console.WriteLine(" > Hasil " + a + " - " + b + " = " + Pengurangan(a, b));
                    break;
                case ':':
                    Console.WriteLine(" > Hasil " + a + " : " + b + " = " + Pembagian(a, b));
                    break;
                case '*':
                    Console.WriteLine(" > Hasil " + a + " * " + b + " = " + Perkalian(a, b));
                    break;
                default:
                    Console.WriteLine(" > Maaf Operasi Yang Anda Pilih Tidak Tersedia.");
                    break;
            }
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
    }
}