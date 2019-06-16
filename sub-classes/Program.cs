using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sub_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> identity = new List<Person>();
            Person one = new Person("William", "Bill");
            identity.Add();
            one = new SuperHero("Mr Incredible", "super strength", "Wade Turner");
            identity.Add();
            one = new Villan("The Joker", "Batman");
            identity.Add();
            Person two = new Person("timothy", "tim");
            identity.Add();
            two = new SuperHero("dr strange", " magic", "dr steven strange");
            identity.Add();
            two = new Villan("magnito", "professor x");
            identity.Add();
            foreach (Person x in identity)
            {
                Console.WriteLine($"{x.ToString()}{x.PrintGreeting()}");
            }
            Console.Read();

        }
    }









    public class Person
    {
        public string Name { get; set;  }
        public string Nickname { get; set;  }

        public Person(string x, string y)
        {
            Name = x;
            Nickname = y;
        }

        public virtual string ToString()
        {
            return $"Hi, my name is {Name}, you can call me {Nickname}.";
        }

        public override string ToString()
        {
            return $"{Name}: ";
        }
    }

    public class SuperHero : Person
    {
        
        public string RealName { get; set; }
        public string SuperPower { get; set; }
        public override string PrintGreeting()
        {
            return $"I am {RealName}. When I am {Name}, my super power is {SuperPower}!";
        }

    }

    public class Villian : Person
    {
        public string Nemesis { get; set; }
        public override string PrintGreeting()
        {
            return $"I am the {Name}. Have you seen {Nemesis}?";
        }

    }
}
