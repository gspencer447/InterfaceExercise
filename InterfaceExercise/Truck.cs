using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public double BedSize { get; set; }
        public bool IsOffroad { get; set; }
        public string BusinessName { get; set; }
        public int YearsInOperation { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWindows { get; set; }
        public bool HasSunroof { get; set; }

    public void PrintTruckInfo()
    {
            Console.WriteLine("Truck information:");
            Console.WriteLine($"Bed Size: {BedSize}");
            Console.WriteLine($"Is Offroad: {IsOffroad}");
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
