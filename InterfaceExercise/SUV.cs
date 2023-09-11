using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public double CargoHoldSize { get; set; }
        public bool HasThirdRowSeats { get; set; }
        public string BusinessName { get; set; }
        public int YearsInOperation { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfWindows { get; set; }
        public bool HasSunroof { get; set; }

        public void PrintSUVInfo()
        {
            Console.WriteLine("SUV information:");
            Console.WriteLine($"Cargo Hold Size: {CargoHoldSize}");
            Console.WriteLine($"Has Third Row Seats: {HasThirdRowSeats}");
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
