using System;

namespace MultiInterface
{
    class Program
    {
        interface IRunnable
        {
            void Run();
        }
        interface IFlyable
        {
            void Fly();
        }
        class Vehicle
        {
            public string Year;
            public string Company;
            public float HP;
        }

        class FlyingCar : Vehicle, IRunnable, IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("Fly!");
            }

            public void Run()
            {
                Console.WriteLine("Run!");
            }
        }
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();
            car.Company = "현대";

            IRunnable runnable = car as IRunnable; //형변환
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
