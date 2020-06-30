using System;
using System.Collections.Generic;
using System.Text;
using TugasPolyDanCol.ClassInduk;

namespace TugasPolyDanCol.ClassAnak
{
    public class karyawanTetap : Karyawan
    {
        public double gajiBulanan { get; set; }

        public override double Gaji()
        {
            double hasil;
            hasil = gajiBulanan;
            return hasil;
        }
    }
}
