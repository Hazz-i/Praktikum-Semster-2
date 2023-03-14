using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class praktikum1
    {
        static void Main(string[] args)
        {

            Console.Write("Input A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hasil dari penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
            Console.WriteLine("Hasil dari pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("Hasil dari perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("Hasil dari pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan Untuk Keluar");
            Console.ReadKey();
        }

        static int penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}