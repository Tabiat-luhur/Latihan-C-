using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan2
{
    public class Calculate
    {
        public int a { get; set; }
        public int b { get; set; }
        public char c { get; set; }

        public void tambah(int a, int b)
        {
            Console.WriteLine(" > Hasil " + a + " + " + b + " = " + (a + b));
        }
        public void kurang(int a, int b)
        {
            Console.WriteLine(" > Hasil " + a + " - " + b + " = " + (a - b));
        }
        public void bagi(int a, int b)
        {
            Console.WriteLine(" > Hasil " + a + " : " + b + " = " + (a / b));
        }
        public void kali(int a, int b)
        {
            Console.WriteLine(" > Hasil " + a + " * " + b + " = " + (a * b));
        }

    }
}
