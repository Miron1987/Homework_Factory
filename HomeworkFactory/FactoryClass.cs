using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFactory
{
    public abstract class FactoryClass
    {

        public BMW OrderBMW()
        {
            BMW bmw;
            bmw = CreateBMW();
            bmw.Prepare();
            bmw.Body();
            bmw.Engine();
            bmw.Electric();
            bmw.Constructing();
            return bmw;
        }

        protected abstract BMW CreateBMW();
    }

    public class BMWSeriesOneFactory : FactoryClass
    {
        protected override BMW CreateBMW()
        {
            return new BMWSeriesOne();
        }
    }

    public class BMWSeriesTwoFactory : FactoryClass
    {
        protected override BMW CreateBMW()
        {
            return new BMWSeriesTwo();
        }
    }


    public abstract class BMW
    {
        public string Model { get; set; }
        public string EngineCar { get; set; }
        public string BodyCar { get; set; }

        public void Prepare()
        {
            Console.WriteLine($"Готовимся к сборке модели {Model}");
        }

        public void Body()
        {
            Console.WriteLine($"Отдельно собираем кузов {BodyCar}");
        }

        public void Engine()
        {
            Console.WriteLine($"Собираем двигатель {EngineCar}");
        }

        public void Electric()
        {
            Console.WriteLine("Готовим электрику");
        }

        public void Constructing()
        {
            Console.WriteLine("Собираем все вместе");
        }
    }

    public class BMWSeriesOne : BMW
    {

       public BMWSeriesOne(string model = "BMWSeriesOne", string engineCar = "8-цилиндровый W12", 
           string bodyCar = "седан")
        {
            Model = model;
            EngineCar = engineCar;
            BodyCar = bodyCar;

        }

    }

    public class BMWSeriesTwo : BMW
    {

        public BMWSeriesTwo(string model = "BMWSeriesTwo", string engineCar = "6-цилиндровый W8",
            string bodyCar = "хэтчбек")
        {
            Model = model;
            EngineCar = engineCar;
            BodyCar = bodyCar;

        }

    }
}
