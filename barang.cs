using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barang
{
    abstract class buku
    {
        public int ISBN;
        public static int jumlah_buku = 0;

        public buku(int ISBN)
        {
            this.ISBN = ISBN;
            jumlah_buku ++;
        }
        public abstract void hitung_buku(); // Penerapan Polymorphism Override Dimana saya menggunakan keyword virtual
                                            // pada method yang terletak pada parent class

        public class horror : buku
        {
            public string judul;
            public int tahun_terbit;
            public int jumlah_halaman;
            public static int jumlah_buku_horror = 0;

            public horror(int ISBN, string judul, int tahun_terbit, int jumlah_halaman) : base(ISBN)
            {
                this.judul          = judul;
                this.tahun_terbit   = tahun_terbit;
                this.jumlah_halaman = jumlah_halaman;
                jumlah_buku_horror  ++;

                Console.WriteLine("\nBuku : " + judul);
                Console.WriteLine("Tahun Terbit : " + tahun_terbit);
                Console.WriteLine("Jumlah Halaman : " + jumlah_halaman);
                
            }
            public override void hitung_buku() // Penerapan Polymorphism Override Dimana saya menggunakan keyword override
                                               // pada method yang terletak pada child class
            {
                Console.WriteLine($"Jumlah Buku Horror Saat ini Adalah {jumlah_buku_horror}");
            }

        }

        public class fantasi : buku
        {
            public string judul;
            public int tahun_terbit;
            public int jumlah_halaman;
            public static int jumlah_buku_fantasi = 0;

            public fantasi(int ISBN, string judul, int tahun_terbit, int jumlah_halaman) : base(ISBN)
            {
                this.judul = judul;
                this.tahun_terbit = tahun_terbit;
                this.jumlah_halaman = jumlah_halaman;
                jumlah_buku_fantasi ++;

                Console.WriteLine("\nBuku : " + judul);
                Console.WriteLine("Tahun Terbit : " + tahun_terbit);
                Console.WriteLine("Jumlah Halaman : " + jumlah_halaman);
            }

            public override void hitung_buku() // Penerapan Polymorphism Override Dimana saya menggunakan keyword override
                                               // pada method yang terletak pada child class
            {
                Console.WriteLine($"Jumlah Buku Fantasi Saat ini Adalah {jumlah_buku_fantasi}");
            }
        }

        public class misteri : buku
        {
            public string judul;
            public int tahun_terbit;
            public int jumlah_halaman;
            public static int jumlah_buku_misteri = 0;

            public misteri(int ISBN, string judul, int tahun_terbit, int jumlah_halaman) : base(ISBN)
            {
                this.judul          = judul;
                this.tahun_terbit   = tahun_terbit;
                this.jumlah_halaman = jumlah_halaman;
                jumlah_buku_misteri ++;

                Console.WriteLine("\nBuku : " + judul);
                Console.WriteLine("Tahun Terbit : " + tahun_terbit);
                Console.WriteLine("Jumlah Halaman : " + jumlah_halaman);
            }
            public override void hitung_buku() // Penerapan Polymorphism Override Dimana saya menggunakan keyword override
                                               // pada method yang terletak pada child class
            {
                Console.WriteLine($"Jumlah Buku Fantasi Saat ini Adalah {jumlah_buku_misteri}");
            }
        }
    }

    public class jurnal
    {
        public int nomer_seri;

        public jurnal(int nomer_seri)
        {
            this.nomer_seri = nomer_seri;
        }
        public class jurnal_penelitian : jurnal
        {
            public string judul;
            public string penulis;
            public int    tahun_terbit;
            public static int    jumlah_jurnal_penelitian = 0;

            public jurnal_penelitian(int nomer_seri, string judul, string penulis, int tahun_terbit) : base(nomer_seri)
            {
                this.judul        = judul;
                this.penulis      = penulis;
                this.tahun_terbit = tahun_terbit;
                jumlah_jurnal_penelitian ++ ;

                Console.WriteLine("\nNomer Seri : " + nomer_seri);
                Console.WriteLine("Judul : " + judul);
                Console.WriteLine("Penulis : " + penulis);
                Console.WriteLine("Tahun Terbit : " + tahun_terbit);
            }
            public void hitung_jurnal() // Penerapan Polymorphism Override Dimana saya menggunakan keyword override
                                               // pada method yang terletak pada child class
            {
                Console.WriteLine($"Jumlah Buku Fantasi Saat ini Adalah {jumlah_jurnal_penelitian}");
            }

        }

        public class jurnal_ilmiah : jurnal
        {
            public string judul;
            public string penulis;
            public int    tahun_terbit;
            public static int jumlah_jurnal_ilmiah = 0;

            public jurnal_ilmiah(int nomer_seri, string judul, string penulis, int tahun_terbit) : base(nomer_seri)
            {
                this.judul        = judul;
                this.penulis      = penulis;
                this.tahun_terbit = tahun_terbit;
                jumlah_jurnal_ilmiah++;

                Console.WriteLine("\nNomer Seri : " + nomer_seri);
                Console.WriteLine("Judul : " + judul);
                Console.WriteLine("Penulis : " + penulis);
                Console.WriteLine("Tahun Terbit : " + tahun_terbit);
            }
            public void hitung_jurnal()
            {
                Console.WriteLine($"Jumlah Jurnal Penelitian Saat ini adalah {jumlah_jurnal_ilmiah}");
            }
        }
    }
}
