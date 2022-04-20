using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4431
{
        internal class Program
        {
            public static void Main(string[] args)
            {
                Karyawan kry1 = new Karyawan("190302123", "Paijo", 3000000);
                Karyawan kry2 = new Karyawan("190302124", "Jono", 2000000);
                Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1    {0}/{1}         {2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
                Console.WriteLine("2    {0}/{1}         {2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);

                Console.WriteLine();
                Console.WriteLine("Asyiiiiik kenaikan gaji 10%!!");
                Console.WriteLine();

                kry1.NaikGaji(10);
                kry2.NaikGaji(10);

                Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1    {0}/{1}         {2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
                Console.WriteLine("2    {0}/{1}         {2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);
            }
        }
    }