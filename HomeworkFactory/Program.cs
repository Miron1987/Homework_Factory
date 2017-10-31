using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            FactoryClass bmw1 = new BMWSeriesOneFactory();
            FactoryClass bmw2 = new BMWSeriesTwoFactory();

            BMW bmwCar = bmw1.OrderBMW();

            Console.WriteLine();

            bmwCar = bmw2.OrderBMW();



        }
    }
}
