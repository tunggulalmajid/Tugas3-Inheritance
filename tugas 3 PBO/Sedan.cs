using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_3_PBO
{
    internal class Sedan : Otomobil
    {
        public string warnaKapMesin;
        public int tahunKendaraan, jumlahKursi, kecepatanMaksimum;
        public double luasBagasi;
        public Sedan(string jenisKendaraan, string merkKendaraan, string typeKendaraan, string warna, 
            int tahunKendaraan,  double luasBagasi, string warnaKapMesin, int jumlahKursi, int kecepatanMaksimum) :
            base (jenisKendaraan, merkKendaraan,typeKendaraan, warna)
        {
            this.jenisKendaraan = jenisKendaraan;
            this.merkKendaraan = merkKendaraan;
            this.typeKendaraan = typeKendaraan;
            this.warna = warna;
            this.tahunKendaraan = tahunKendaraan;
            this.luasBagasi = luasBagasi;
            this.warnaKapMesin = warnaKapMesin;
            this.jumlahKursi = jumlahKursi;
            this.kecepatanMaksimum = kecepatanMaksimum ;
        }
        public void TampilInfoSedan()
        {
            Console.WriteLine($"Jenis Kendaraan    : {jenisKendaraan}");
            Console.WriteLine($"Merk               : {merkKendaraan}");
            Console.WriteLine($"Tipe               : {typeKendaraan}");
            Console.WriteLine($"Warna              : {warna}");
            Console.WriteLine($"Tahun              : {tahunKendaraan}");
            Console.WriteLine($"Luas Bagasi        : {luasBagasi} m3");
            Console.WriteLine($"Warna Kap Mesin    : {warnaKapMesin}");
            Console.WriteLine($"Jumlah Kursi       : {jumlahKursi} Kursi");
            Console.WriteLine($"Kecepatan Maksimum : {kecepatanMaksimum} Km/Jam");
            Console.WriteLine("");
        }

    }
}
