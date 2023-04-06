using praktikum4;
using System;

namespace TheCoffeMachine
{
    class program { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word!");

            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMachine yummioffe = new CoffeMachine(coffe, water);

            //1st cup
            Console.WriteLine("check " + yummioffe.checkingAvaibility());
            string result = yummioffe.makeEspreso();
            Console.WriteLine("reuslt " + result);

            //2nd cup
            Console.WriteLine("check " + yummioffe.checkingAvaibility());
            result = yummioffe.makeEspreso();
            Console.WriteLine("reuslt " + result);

            //3nd cup
            Console.WriteLine("check " + yummioffe.checkingAvaibility());
            result = yummioffe.makeEspreso();
            Console.WriteLine("reuslt " + result);

            //4nd cup
            Console.WriteLine("check " + yummioffe.checkingAvaibility());
            result = yummioffe.makeEspreso();
            Console.WriteLine("reuslt " + result);

            Console.WriteLine("check " + yummioffe.checkingAvaibility());
            result = yummioffe.makeEspreso();
            Console.WriteLine("reuslt " + result);

            Console.WriteLine("check " + yummioffe.checkingAvaibility());
            result = yummioffe.makeEspreso();
            Console.WriteLine("reuslt " + result);

            Console.WriteLine("chck " + yummioffe.checkingAvaibility());
        }

    }

}
