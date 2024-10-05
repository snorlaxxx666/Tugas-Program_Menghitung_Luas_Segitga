using System;
using System.Configuration.Assemblies;

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Pesan Selamat Datang
        Console.WriteLine("-----> Menghitung luas segitiga dengan program C# <-----");

        // Meminta pengguna untuk memasukkan panjang alas segitiga Contoh (50)
        // Input yang diterima dapat berupa bilangan bulat atau desimal
        Console.Write("Masukkan panjang alas segitiga: ");
        double alas = Convert.ToDouble(Console.ReadLine()); // Mengubah input dari string ke tipe data double

        // Meminta pengguna untuk memasukkan tinggi segitiga Contoh : (100)
        // Input juga dapat berupa bilangan bulat atau desimal
        Console.Write("Masukkan tinggi segitiga: ");
        double tinggi = Convert.ToDouble(Console.ReadLine()); // Mengonversi input dari string ke tipe data double

        // Menghitung luas segitiga menggunakan rumus: (alas * tinggi) / 2
        // Rumus ini berlaku untuk menghitung luas segitiga di mana alas dan tinggi diketahui
        double luas = alas * tinggi / 2;

        // Menampilkan hasil perhitungan luas segitiga kepada pengguna
        Console.WriteLine("Luas segitiga adalah: " + luas);
        Console.WriteLine("Selesai");
    }
}