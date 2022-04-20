using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4431
{
    internal class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public float GajiBulanan { get; set; }
        public Karyawan(string nik, string nama, float gajibulanan)
        {
            this.Nik = nik;
            this.Nama = nama;
            if (gajibulanan < 0)
            {
                gajibulanan = 0;
            }
            this.GajiBulanan = gajibulanan;
        }

        public void NaikGaji(float persenan)
        {
            this.GajiBulanan = persenan / 100 * this.GajiBulanan + this.GajiBulanan;
        }

    }
}
