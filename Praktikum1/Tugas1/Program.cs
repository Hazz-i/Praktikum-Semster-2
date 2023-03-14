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
            Console.WriteLine("\t\tMenu");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("\nPilih Menu: ");
            int menu = Convert.ToInt32(Console.ReadLine()); ;

            if (menu > 4 || menu < 1)
            {
                Console.WriteLine("Data Not Found");
            }
            else
            {
                switch (menu)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("\t\tPenjumlahan");
                            Console.Write("Input A: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Input B: ");
                            int b = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n\nHasil dari penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
                            Console.ReadKey();

                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\t\tPengurangan");
                            Console.Write("Input A: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Input B: ");
                            int b = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n\nHasil dari pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                            Console.ReadKey();

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\t\tPerkalian");
                            Console.Write("Input A: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Input B: ");
                            int b = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n\nHasil dari perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
                            Console.ReadKey();

                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\t\tPembagian");
                            Console.Write("Input A: ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Input B: ");
                            int b = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n\nHasil dari pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
                            Console.ReadKey();

                            break;
                        }
                }
            }
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