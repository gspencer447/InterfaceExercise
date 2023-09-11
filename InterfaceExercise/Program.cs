using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Truck truck1 = new Truck();
            truck1.BedSize = 15;
            truck1.IsOffroad = true;
            truck1.BusinessName = "Ford";
            truck1.YearsInOperation = 120;
            truck1.NumberOfWheels = 4;
            truck1.NumberOfDoors = 2;
            truck1.NumberOfWindows = 4;
            truck1.HasSunroof = true;

            Car car1 = new Car();
            car1.TrunkSize = 8;
            car1.IsSportsCar = false;
            car1.BusinessName = "Toyota";
            car1.YearsInOperation = 86;
            car1.NumberOfWheels = 4;
            car1.NumberOfDoors = 4;
            car1.NumberOfWindows = 4;
            car1.HasSunroof = false;

            SUV suv1 = new SUV();
            suv1.CargoHoldSize = 12;
            suv1.HasThirdRowSeats = true;
            suv1.BusinessName = "Jeep";
            suv1.YearsInOperation = 82;
            suv1.NumberOfWheels = 4;
            suv1.NumberOfDoors = 4;
            suv1.NumberOfWindows = 6;
            suv1.HasThirdRowSeats = true;

            truck1.PrintTruckInfo();
            Console.WriteLine("----------");
            car1.PrintCarInfo();
            Console.WriteLine("----------");
            suv1.PrintSUVInfo();
        }
    }
}
