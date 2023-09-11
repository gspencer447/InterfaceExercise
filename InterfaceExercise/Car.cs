using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public double TrunkSize { get; set; }
        public bool IsSportsCar { get; set; }
        public string BusinessName { get; set; }
        public int YearsInOperation { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWindows { get; set; }
        public bool HasSunroof { get; set; }

        public void PrintCarInfo()
        {
            Console.WriteLine("Car information:");
            Console.WriteLine($"Trunk Size: {TrunkSize}");
            Console.WriteLine($"Is Sports Car: {IsSportsCar}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
            Console.WriteLine($"Number of Windows: {NumberOfWindows}");
            Console.WriteLine($"Has Sunroof: {HasSunroof}");
            Console.WriteLine();
            Console.WriteLine("Company information:");
            Console.WriteLine($"Business Name: {BusinessName}");
            Console.WriteLine($"Years in Operation: {YearsInOperation}");
        }
    }
}
