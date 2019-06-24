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
            identity.Add(one);
            SuperHero two = new SuperHero("Mr Incredible", "super strength", "Wade Turner");
            identity.Add(two);
            Villian three = new Villian("The Joker", "Batman");
            identity.Add(three);

            foreach (Person x in identity)
            {
                Console.WriteLine($"{x.ToString()}{x.PrintGreeting()}");
            }
            Console.Read();

        }
    }



          
    public class Person
    {
        public string Name { get; set; }
        public string Nickname { get; set; }

        public Person(string name, string nickname)
        {
            Name = name;
            Nickname = nickname;
        }

        public virtual string PrintGreeting()
        {
            return $"Hi, my name is {Name}, you can call me {Nickname}.";
        }


    }

    public class SuperHero : Person
    {

        public string RealName { get; set; }
        public string SuperPower { get; set; }
        public SuperHero(string name, string realName, string superPower) : base(name, null)
        {
            RealName = realName;
            SuperPower = superPower;

        }
        public override string PrintGreeting()
        {
            return $"I am {RealName}. When I am {Name}, my super power is {SuperPower}!";
        }

    }

    public class Villian : Person
    {

        public string Nemesis { get; set; }


        public Villian(string name, string nemesis) : base(name, null)
        {
            Nemesis = nemesis;
        }

        public override string PrintGreeting()
        {
            return $"I am the {Name}. Have you seen {Nemesis}?";
        }

    }
}

