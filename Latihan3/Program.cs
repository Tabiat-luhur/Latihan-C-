namespace Latihan3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            Console.WriteLine("Hello, World!");
            Console.Write(" > Masukan Nama : ");
            mhs.Nama = Console.ReadLine();
            Console.Write(" > Masukan Nim : ");
            mhs.Nim = Console.ReadLine();
            mhs.Registrasi();
            Console.ReadKey();
            mhs.IsiKrs();
        }
    }
}