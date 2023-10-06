using System;

namespace anggota
{
    interface IMeminjam
    {
        void meminjam();
    }

    public class Mahasiswa : IMeminjam // Perbaiki penamaan kelas (Mahasiswa bukan mahasiswa)
    {
        public string nama;
        public string fakultas;
        public string jurusan;
        public long NIM;
        public static int jumlah_member = 0;
        private int angkatan;

        public Mahasiswa(string nama, string fakultas, string jurusan, long NIM, int angkatan)
        {
            this.nama = nama;
            this.fakultas = fakultas;
            this.jurusan = jurusan;
            this.NIM = NIM;
            Angkatan_Accessible = angkatan;
            jumlah_member++;

            Console.WriteLine($"Nama : {nama}\nFakultas : {fakultas}\nJurusan : {jurusan}\nNIM : {NIM}\nAngkatan : {Angkatan_Accessible}");
        }

        public int Angkatan_Accessible
        {
            get { return angkatan; }
            set
            {
                if (value == 2018 || value == 2019 || value == 2020 || value == 2021 || value == 2022 || value == 2023)
                {
                    angkatan = value;
                }
                else
                {
                    angkatan = 9999;
                }
            }
        }

        public void meminjam()
        {
            Console.WriteLine("Mahasiswa meminjam buku ");
        }
    }
}
