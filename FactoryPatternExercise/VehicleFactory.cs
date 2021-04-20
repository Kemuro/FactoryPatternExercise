using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    static class VehicleFactory
    {

        public static IVehicle GetVehicle(string numOfDoors)
        {
            switch (numOfDoors.ToLower())
            {
                case "two":
                case "2":
                    return new Coupe();

                case "four":
                case "4":
                    return new Sedan();

                default:
                    return new NotInInventory();
            }
        }
    }
}
