using tugas3;
using System;

namespace LatihanClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            mobil mobil1 = new mobil();
            mobil mobil2 = new mobil();

            mobil1.merek = "CIVIC";
            mobil1.model = "HONDA";
            mobil1.warna = "PUTIH";
            mobil1.JMLPintu = 4;
            mobil1.tahunPengeluaran = 2015;

            //Convert.ToInt32(Console.ReadLine());

            mobil1.gas(120);
            mobil1.klakson("PIM");
            mobil1.tampilkanInfo();
        }
    }
}