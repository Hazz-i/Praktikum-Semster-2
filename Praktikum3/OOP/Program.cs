using OOP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LatihanClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mahasiswa1 = new Mahasiswa();
            Mahasiswa mahasiswa2 = new Mahasiswa();

            mahasiswa1.Nama = "Wahid";
            mahasiswa1.Nim = "22.11.4878";
            mahasiswa1.Ipk = 4.0f;

            mahasiswa2.Nama = "Hasim";
            mahasiswa2.Nim = "22.11.4878";
            mahasiswa2.Ipk = 3.9f;

            //Convert.ToInt32(Console.ReadLine());

            mahasiswa1.Registrasi();
            mahasiswa1.IsiKrs();

            mahasiswa2.Registrasi();
            mahasiswa2.IsiKrs();
        }
    }
}