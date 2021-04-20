using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Sedan : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Your selected sedan is available for a test drive.");
        }
    }
}
