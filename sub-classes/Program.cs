using System;
using System.Collections.Generic;


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
        public SuperHero(string name, string realName, string superPower) : base(name, name null);{
           RealName = realName;
            SuperPower = superPower;
        return $"I am {RealName}. When I am {Name}, my super power is {SuperPower}!";
        }
        public override string PrintGreeting()
        {
        return _greeting(); 
        }

    }

    public class Villian : Person
    {
        public string Nemesis { get; set; }
         private string _greetings;
       
        public override string PrintGreeting()
        {
            return $"I am the {Name}. Have you seen {Nemesis}?";
        }

    }
}
