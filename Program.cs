using System;
using System.Collections.Generic;
using TugasPolyDanCol.ClassAnak;
using TugasPolyDanCol.ClassInduk;

namespace TugasPolyDanCol
{
	class Program
	{
        static void Main(string[] args)
		{
            Console.Title = "Aplikasi Perhitungan Gaji Karyawan";
            List<Karyawan> karyawan = new List<Karyawan>();
            Menu(karyawan);
          
            Console.ReadKey();
        }

        static void Menu(List<Karyawan> karyawan)
        {
            int pil;

            do
            {
                Console.WriteLine("\nMenu Aplikasi");
                Console.WriteLine("\n1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar");
                Console.Write("Pilih nomor menu [1..4] : ");

                pil = Convert.ToInt32(Console.ReadLine());
                switch (pil)
                {
                    case 1:
                        Console.Clear();
                        tambahData(karyawan);
                        break;
                    case 2:
                        Console.Clear();
                        hapusData(karyawan);
                        break;
                    case 3:
                        Console.Clear();
                        tampilData(karyawan);
                        break;
                }

            } while (pil != 4);
        }


        static void tambahData(List<Karyawan> karyawan)
        {
            Console.Clear();
            int pil;
            Console.WriteLine("Tambah Data Karyawan");
            InvalidOption:
            Console.Write("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
            pil = Convert.ToInt32(Console.ReadLine());

            if (pil == 1)
            {

                // membuat instance dari class KaryawanTetap
                karyawanTetap karyawanTetap = new karyawanTetap();


                Console.WriteLine("Tambah Karyawan Tetap");

                // Input Data ke instance Karyawantetap
                Console.Write("Masukkan NIK \t\t: ");
                karyawanTetap.Nik = Console.ReadLine();

                Console.Write("Masukkan Nama \t\t: ");
                karyawanTetap.Nama = Console.ReadLine();

                Console.Write("Masukkan Gaji Bulanan \t: ");
                karyawanTetap.gajiBulanan = Convert.ToDouble(Console.ReadLine());

                // Menambahkan Data
                karyawan.Add(karyawanTetap);

            }
            else if (pil == 2)
            {
                // Membuat instance dari class KaryawanHarian()
                karyawanHarian karyawanHarian = new karyawanHarian();


                Console.WriteLine("Tambah Karyawan Harian");

                // Input data ke instance karyawanHarian
                Console.Write("Masukkan NIK \t\t: ");
                karyawanHarian.Nik = Console.ReadLine();

                Console.Write("Masukkan Nama \t\t: ");
                karyawanHarian.Nama = Console.ReadLine();

                Console.Write("Masukkan Upah per Jam \t: ");
                karyawanHarian.upahPerjam = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Jam Kerja \t: ");
                karyawanHarian.jumlahJam = Convert.ToDouble(Console.ReadLine());

                // Menambah data ke list karyawan
                karyawan.Add(karyawanHarian);

            }
            else if (pil == 3)
            {
                // Membuat Instance dari class SAles
                sales sales = new sales();

                Console.WriteLine("Tambah Karyawan Harian");

                // Input data ke Instance sales
                Console.Write("Masukkan NIK \t\t: ");
                sales.Nik = Console.ReadLine();

                Console.Write("Masukkan Nama \t\t: ");
                sales.Nama = Console.ReadLine();

                Console.Write("Masukkan Jml Penjualan \t: ");
                sales.jumlahPenjualan = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Komisi \t: ");
                sales.komisi = Convert.ToDouble(Console.ReadLine());

                // menambah data ke list karyawan
                karyawan.Add(sales);
            }
            else
            {
                // Handle jika inputan tidak valid
                Console.WriteLine("Pilihan tidak ada, silahkan masukkan lagi");
                goto InvalidOption;
            }

        }

        static void hapusData(List<Karyawan> karyawan)
        {
            Console.Clear();

            // menampilkan selamat datang dan menu aplikasi
            Console.WriteLine("=====================================");
            Console.WriteLine("======== HAPUS DATA KARYAWAN ========");
            Console.WriteLine("=====================================");

            // insiailasi variable found
            bool found = true;

            // input nik
            string nik;
            Console.Write("\nMasukkan NIK Karyawan: ");
            nik = Console.ReadLine();

            // looping data karyawan
            for (int i = 0; i < karyawan.Count; i++)
            {
                // seleksi jika inputan nik sama dengan pada nik di list  karyawan
                if (karyawan[i].Nik == nik)
                {
                    // data jika ditemukan
                    karyawan.Remove(karyawan[i]);
                    found = true;
                    break;
                }
                else
                {
                    // data jika tdk ditemukan
                    found = false;
                }
            }

            if (!found)
            {
                Console.WriteLine("Data tidak dengan NIK = {0} tidak ditemukan", nik);
            }
            else
            {
                Console.WriteLine("Data dengan NIK = {0} berhasil dihapus", nik);
            }
        }

        static void tampilData(List<Karyawan> karyawan)
        {
            Console.Clear();

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji\t\t |");
            Console.WriteLine("==================================================");
            for (int i = 0; i < karyawan.Count; i++)
            {

                Console.WriteLine(" {0}. | {1} {2} \t\t | {3} \t |", i + 1, karyawan[i].Nik, karyawan[i].Nama, karyawan[i].Gaji());
             
            }
        }
    }
}
