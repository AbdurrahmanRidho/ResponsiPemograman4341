using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4341
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama     : Abdurrahman Ridho");
            Console.WriteLine("NIM      : 21.11.4341");
            Console.WriteLine("Kelas    : 21 IF 08");

            Console.WriteLine("\n");

            Karyawan karyawan1 = new Karyawan(123, "Abdurrahman", 5000000);
            Karyawan karyawan2 = new Karyawan(456, "Ridho", 4000000);
            Karyawan karyawan3 = new Karyawan(789, "Ahmad", -100000);

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);
            
            Console.WriteLine("\n\nAsikkkkk dpt kenaikan gaji nih!!!\n");

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.Nama, karyawan3.GajiBulanan);

            Console.ReadKey();
        }
    }

    internal class Karyawan
    {
        private int v;
        private int v1;
        private string v2;

        public Karyawan(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Karyawan(int v1, string v2, int v) : this(v1, v2)
        {
            this.v = v;
        }

        public object GajiBulanan { get; internal set; }
        public object NaikGaji { get; internal set; }
        public int Nama { get; internal set; }
        public int NIK { get; internal set; }
    }
}
