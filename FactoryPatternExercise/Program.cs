using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, how many doors would you like your vehicle to have?");
            IVehicle testDrive1 = VehicleFactory.GetVehicle(Console.ReadLine());

            testDrive1.Drive();
        }
    }
}
