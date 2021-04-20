using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class NotInInventory : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("No vehicles of this type in our inventory");
        }
    }
}
