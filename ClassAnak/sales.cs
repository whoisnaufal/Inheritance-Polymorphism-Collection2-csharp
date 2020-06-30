using System;
using System.Collections.Generic;
using System.Text;
using TugasPolyDanCol.ClassInduk;

namespace TugasPolyDanCol.ClassAnak
{
    public class sales : Karyawan
    {
        public double jumlahPenjualan { get; set; }
        public double komisi { get; set; }

        public override double Gaji()
        {
            double hasil;
            hasil = jumlahPenjualan * komisi;
            return hasil;
        }
    }
}
