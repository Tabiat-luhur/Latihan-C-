using Latihan2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {

        static void Main(string[] args)
        {
            Calculate kalk = new Calculate();
            Console.WriteLine("     -- KALKULATOR --");
            Console.Write(" > Masukan Angka ke-1 = ");
            kalk.a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" > Masukan Angka ke-2 = ");
            kalk.b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" > Masukan Operasi [ + / - / : / * ] = ");
            kalk.c = Convert.ToChar(Console.ReadLine());
            switch (kalk.c)
            {
                case '+':
                    kalk.tambah(kalk.a, kalk.b);
                    break;
                case '-':
                    kalk.kurang(kalk.a, kalk.b);
                    break;
                case ':':
                    kalk.bagi(kalk.a, kalk.b);
                    break;
                case '*':
                    kalk.kali(kalk.a, kalk.b);
                    break;
                default :
                    Console.WriteLine(" > Operasi Yang Anda Pilih Tidak Tersedia.");
                    break;
            }
        }
    }
}