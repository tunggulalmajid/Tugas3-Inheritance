using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_3_PBO
{
    internal class Truck : Otomobil
    {
        public string jenisMuatan;
        public int beratMuatan;
        public Truck(string jenisKendaraan, string merkKendaraan, string typeKendaraan, string warna, string jenisMuatan, int beratMuatan) 
            : base(jenisKendaraan, merkKendaraan, typeKendaraan,warna)  
        {
            this.jenisKendaraan = jenisKendaraan;
            this.merkKendaraan = merkKendaraan;
            this.typeKendaraan = typeKendaraan;
            this.warna = warna;
            this.jenisMuatan = jenisMuatan;
            this.beratMuatan = beratMuatan;
        }
        public void TampilInfoTruck()
        {
            Console.WriteLine($"Jenis Kendaraan    : {jenisKendaraan}");
            Console.WriteLine($"Merk               : {merkKendaraan}");
            Console.WriteLine($"Tipe               : {typeKendaraan}");
            Console.WriteLine($"Warna              : {warna}");
            Console.WriteLine($"Jenis Muatan       : {jenisMuatan}");
            Console.WriteLine($"Berat Muatan       : {beratMuatan} Kg");
            Console.WriteLine("");
        }
    }
}
