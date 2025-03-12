using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_3_PBO
{
    internal class Motor : Otomobil
    {
        public string jenisBan, jenisLampu, jenisPengereman;
        public double tangkiBensin;
        public Motor(string jenisKendaraan, string merkKendaraan, string typeKendaraan, string warna, string jenisBan, 
            string jenisLampu, string jenisPengereman, double tangkiBensin)
           : base(jenisKendaraan, merkKendaraan, typeKendaraan, warna)
        {
            this.jenisKendaraan = jenisKendaraan;
            this.merkKendaraan = merkKendaraan;
            this.typeKendaraan = typeKendaraan;
            this.warna = warna;
            this. jenisBan = jenisBan;
            this.jenisLampu = jenisLampu;
            this.jenisPengereman = jenisPengereman;
            this.tangkiBensin = tangkiBensin;
            
        }
        public void tampilkanInfoMotor()
        {
            Console.WriteLine($"Jenis Kendaraan           : {jenisKendaraan}");
            Console.WriteLine($"Merk                      : {merkKendaraan}");
            Console.WriteLine($"Tipe                      : {typeKendaraan}");
            Console.WriteLine($"Warna                     : {warna}");
            Console.WriteLine($"Jenis Ban                 : {jenisBan}");
            Console.WriteLine($"Jenis Lampu               : {jenisLampu}");
            Console.WriteLine($"Jenis Pengereman          : {jenisPengereman}");
            Console.WriteLine($"Kapasitas Tangki Bensin   : {tangkiBensin} Liter");
            Console.WriteLine("");
        }
    }
}
