using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan3
{
    internal class Mahasiswa
    {
        // Properties
        public string Nim { get; set; }
        public string Nama { get; set; }
        public float Ipk { get; set; }

        // Method
        public void Registrasi()
        {
            Console.WriteLine("Nama : {0}", Nama);
            Console.WriteLine("NIM : {0}", Nim);
            Console.WriteLine("IPK : {0}", Ipk);
            Console.WriteLine("Telah melakukan Registrasi.");

        }
        public void IsiKrs()
        {
            Console.WriteLine("{0} Sedang Melakukan Proses Krs\n", Nama);

        }
    }
}
