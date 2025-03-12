using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_3_PBO
{
    internal class Otomobil
    {
        public string jenisKendaraan, merkKendaraan,typeKendaraan,warna;
        public Otomobil(string jenisKendaraan, string merkKendaraan,string typeKendaraan, string warna) 
        {
            this.jenisKendaraan = jenisKendaraan;
            this.merkKendaraan = merkKendaraan;
            this.typeKendaraan = typeKendaraan;
            this.warna = warna;
        }
    }
}
