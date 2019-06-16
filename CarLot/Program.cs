using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> invetory = new List<Vehicle>();
            CarLot pioner = new CarLot("pioner", invetory);
            CarLot fordcars = new CarLot("fordcars", invetory); 
            .Add(new Car("tat999", "honda", "liberty", 6000, "coupe", 4));
            invetory.Add(new Truck("dbd8943", "Ford", "F-150", 20000, "short"));
            invetory.Add(new Car("FCH938", "hyundai", "sonata", 10000, "Hatchback", 4));            
            pioner.list(new Car("DBG8D966", "Chevoltet", "Tracker", 9999.99, "Sedan", 4));
            pioner.list(new Truck("DBG8D967", "Ford", "F-150", 1000.01, "Medium"));
            pioner.list(new Car("DBG8D968", "Toyota", "Camrie", 5.01, "Hatchback", 1));
            fordcars.list(new Truck("pne0032", "Ford", "F-250", 20000, "long"))
            fordcars.Print();
            Console.WriteLine("");
            pioner.Print();
            Console.ReadLine();
        }
    }

    // calls the vehicles to make a list for the driver
     class CarLot
    {
        //names the lot 
        public string Names;
        //makes the list of vehicles in the lot        
        public List<Vehicle> vehicles;
        public CarLot(string name)
        {
            Names = name;
            vehicles = new List<Vehicle>();
        }
        public CarLot(string name, List<Vehicle> list)
        {
            vehicles = new List<Vehicle>();
            Names = name;
            foreach (Vehicle v in list)
                vehicles.Add(v);
        }
        public void list(Vehicle v)
        {
            vehicles.Add(v);
        }
        public void Print()
        {
            Console.Write($"{Names}\n" );
            int items = 1;
            foreach (Vehicle v in vehicles)
            {
                Console.Write($"{items}. ");
                v.stats();
                items++;
            }
        }
    }
}
    

    //makes the vehicle classes
     public abstract class Vehicle
    {
        // finds the liscene number of the vehicle
     public string LicenseNumber;
        //finds the make 
     public string Make;
        //finds the model
     public string Model;
        //finds the price 
     public double Price;
        public Vehicle(string license, string make, string model, double price)
        {
        LicenseNumber = license;
        Make = make;
        Model = model;
        Price = price;
        }

     public virtual void stats()
        {
        Console.Write($"License: {LicenseNumber}   Model: {Model}   Make: {Make}   Price: {Price}");
        }
    }
    //car sub class
     public class Car : Vehicle
    {
        // type of car ie sedan coupe
        public string Type;
        //how many doors does the car have
        public string NumberDoors;
    public override void stats()
    {
        Console.Write($"License: {LicenseNumber}   Model: {Model}   Make: {Make}   Type: {Type}   Doors: {NumberDoors}   Price: {Price}");
    }
}
    // truck sub class
     public class Truck : Vehicle
    {
        // truck bedsize ie full exstended 
        public string BedSize;
     public override void stats()
     {
        Console.Write($"License: {LicenseNumber}   Model: {Model}   Make: {Make}   Bed size: {BedSize}   Price: {Price}");
     }
}



