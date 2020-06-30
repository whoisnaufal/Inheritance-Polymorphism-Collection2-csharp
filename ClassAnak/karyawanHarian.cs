using System;
using System.Collections.Generic;
using System.Text;
using TugasPolyDanCol.ClassInduk;

namespace TugasPolyDanCol.ClassAnak
{
    public class karyawanHarian : Karyawan
    {
        public double upahPerjam { get; set; }
        public double jumlahJam { get; set; }

        public override double Gaji()
        {
            double hasil;
            hasil = upahPerjam * jumlahJam;

            return hasil;
        }
    }
}
