using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Coupe : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Your selected coupe is available for a test drive.");
        }
    }
}
