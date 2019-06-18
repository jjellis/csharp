using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> Rent = new List<IRentable>();
            Car car = new Car("Car");
            Rent.Add(car);
            Boat boat = new Boat("Boat");
            Rent.Add(boat);
            House house = new House("House");
            Rent.Add(house);

            foreach (IRentable rentable in Rent)
            {
                Console.WriteLine(rentable.GetDailyRate());
                Console.WriteLine(rentable.GetDescription());                
                
            }
            Console.ReadLine();
        }


    }

    public interface IRentable
    {
        decimal GetDailyRate();
        string GetDescription();
    }

    public class Boat : IRentable
    {//hourly rate
        private decimal _HourlyRate = 20.5m;
        public string Description { get; set; }
        public Boat(string description)
        {
            Description = "This is a boat rental the hourly rate is $20.50";
        }
        public decimal GetDailyRate()
        {
            return Decimal.Round(_HourlyRate * 24, 2);
        }
        public string GetDescription()
        {
            return Description;
        }

    }



    public class House : IRentable
    {//weekley rate
        private decimal _WeeklyRate = 450.5m;
        public string Description { get; set; }
        public House(string description)
        {
            Description = "This is a House rental the weekly rate is $450.50";
        }
        public decimal GetDailyRate()
        {
            return Decimal.Round(_WeeklyRate / 7, 2);
        }
        public string GetDescription()
        {
            return Description;
        }



    }


        public class Car : IRentable
        {//daily rate
            private decimal _DailyRate = 250.5m;
            public string Description { get; set; }
            public Car(string description)
            {
                Description = "This is a car rental the daily rate is $250.50";
            }
            public decimal GetDailyRate()
            {
                return _DailyRate;
            }
            public string GetDescription()
            {
                return Description;
            }

        }
    }

