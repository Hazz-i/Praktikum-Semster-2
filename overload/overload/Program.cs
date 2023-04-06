using System;
using System.Runtime.CompilerServices;

namespace overload
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarasi variabel
            overload min = new overload();

            Console.WriteLine("Temtukan niali minimum dan maximum dari 12, 29 , 11 !\n");
            Console.WriteLine("Nilai min diantara ketiga nilai tersebut adalah\t: {0}", min.nilaiMin(12, 10.7f ));
            Console.WriteLine("Nilai max diantara ketiga nilai tersebut adalah\t: {0}", min.nilaiMax(12, 29, 11));
            Console.ReadKey();
        }
    }
}