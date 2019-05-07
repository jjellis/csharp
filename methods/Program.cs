using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // hello method
             Hello(); 
            //Addition method
            Addition();
            //CatDog method
            CatDog();
            //OddEvent method
            OddEvent();
            //Inches method
            Inches();
            //Echo method
            Echo();
            //killgrams method
            KillGrams();
            //DATE METOD    
            Date();
            //Age method
            Ages();
            //guess method
            Guess();

        }
        public static void Hello()
        {
            Console.WriteLine("Hello What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Bye " + name);
            Console.Read();
        }
        public static void Addition()
        {
            Console.WriteLine("Please enter the first number:");
            int num1 = int.Parse(s: Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is " + (num1 + num2));
            Console.Read();
        }
        public static void CatDog()
        {
            Console.WriteLine("Do you prefer cats or dogs?");
            String animal = Console.ReadLine();
            if (animal == "cats")
            {
                Console.WriteLine("Meow");
            }
            else if (animal == "dogs")
            {
                Console.WriteLine("Woof");

            }
            Console.Read();
        }
        public static void OddEvent()
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(s: Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            Console.Read();
        }
        static void Inches()
        {
            Console.WriteLine("Enter hight in feet");
            int feet = int.Parse(s: Console.ReadLine());
            int inches = feet * 12;
            Console.WriteLine(inches);
            Console.Read();
        }
        static void Echo()
        {
            Console.WriteLine("type a word:");
            string EchoWord = Console.ReadLine();
            string upperEchoWord = EchoWord.ToUpper();
            Console.WriteLine(upperEchoWord + " " + EchoWord + " " + EchoWord);
            Console.Read();
        }
        static void KillGrams()
        {
            Console.WriteLine("Enter weight in pounds");
            double pounds = double.Parse(s: Console.ReadLine());
            double kilo = pounds * 0.453592;
            Console.WriteLine(kilo);
            Console.Read();
        }
        static void Date()
        {
            Console.WriteLine(DateTime.UtcNow.Date);
            Console.Read();
        }
        static void Ages()
        {
            Console.WriteLine("What year were you born?");
            int year = int.Parse(s: Console.ReadLine());
            int age = 2019 - year;
            Console.WriteLine(age);
            Console.Read();
        }
        static void Guess()
        {
            Console.WriteLine("Guess a word!");
            String word = Console.ReadLine();
            if (word == "chsarp")
            {
                Console.WriteLine("Correct!!");
            }
            else
            {
                Console.WriteLine("Wrong!!");

            }
            Console.Read();
        
    }
    }

}

