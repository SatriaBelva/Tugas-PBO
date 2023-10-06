using anggota;
using barang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.Magenta;

            //barang.buku.horror Wanita_Tanah_Jahannam = new buku.horror.horror(123, "Wanita Tanah Jahannam", 2023, 200);
            //barang.buku.horror Susanna = new buku.horror.horror(124, "Susanna", 2023, 200);
            //barang.buku.horror Holy_Mother = new buku.horror.horror(125, "Holy Mother", 2023, 200);
            //barang.buku.horror Lost = new buku.horror.horror(126, "Lost", 2023, 200);
            //barang.buku.horror Paranormal_Activty = new buku.horror.horror(127, "Paranormal Activity", 2009, 150);
            //barang.buku.horror Paranormal_Activty_2 = new buku.horror.horror(128, "Paranormal Activity 2", 2015, 120);
            //barang.buku.horror Paranormal_Activty_3 = new buku.horror.horror(129, "Paranormal Activity 3", 2023, 121);
            //Susanna.hitung_buku();

            //barang.buku.fantasi Divergent = new buku.fantasi.fantasi(1501, "Divergent", 2013, 230);
            //barang.buku.fantasi The_Bliss_Bakery_Trilogy = new buku.fantasi.fantasi(1502, "The Bliss Bakery Trilogy", 2013, 230);
            //barang.buku.fantasi Strange_The_Dreamer = new buku.fantasi.fantasi(1503, "Strange the Dreamer", 2013, 230);
            //barang.buku.fantasi Red_Queen = new buku.fantasi.fantasi(1504, "Red Queen", 2013, 230);
            //Divergent.hitung_buku();

            //Console.WriteLine("\nJumlah Buku Keseluruhan yang kami miliki saat ini adalah " + buku.jumlah_buku);

           
            
            barang.jurnal.jurnal_penelitian penelitian1 = new barang.jurnal.jurnal_penelitian(997417, "Kesalahpahaman yang paling umum tentang anak-anak dengan autisme.", "Satria Belva N.", 2022);
            barang.jurnal.jurnal_penelitian penelitian2 = new barang.jurnal.jurnal_penelitian(997418, "Persepsi bahaya dalam budaya yang berbeda", "Carenina Zahra", 2023);
            penelitian2.hitung_jurnal();

            barang.jurnal.jurnal_ilmiah ilmiah1 = new barang.jurnal.jurnal_ilmiah(917417, "Pengaruh Perubahan Iklim terhadap Keanekaragaman Hayati di Hutan Hujan Tropis", "Haikal Nuril", 2022);
            barang.jurnal.jurnal_ilmiah ilmiah2 = new barang.jurnal.jurnal_ilmiah(917418, "Pengaruh Penggunaan Pestisida terhadap Kualitas Tanah dan Air", "Rafi Jauhari", 2023);
            ilmiah1.hitung_jurnal();
            

            //mahasiswa mahasiswa1 = new mahasiswa("Dhiya", "Ilkom", "SI", 222410101002, 2023);
            //mahasiswa1.Angkatan_Accessible = 2021;
            //Console.WriteLine(mahasiswa1.Angkatan_Accessible);

        }
    }
}
