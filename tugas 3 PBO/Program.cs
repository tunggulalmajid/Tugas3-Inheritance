using System.Security.Cryptography.X509Certificates;
using tugas_3_PBO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sedan");
        Sedan sedan = new Sedan("Mobil Sedan", "Honda","Civic", "Putih", 2022, 10.5, "putih", 5,150);
        sedan.TampilInfoSedan();

        Console.WriteLine("Truck");
        Truck truk = new Truck("Truck","Hino", "Dutro", "Hijau", "Pasir", 150);
        truk.TampilInfoTruck();

        Console.WriteLine("Motor");
        Motor motor = new Motor("Motor","Honda", "Vario", "Putih", "Tubeles", "LED", "Cakram", 5);
        motor.tampilkanInfoMotor();

        Console.ReadLine();

    }
}