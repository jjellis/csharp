using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocos
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("what is your first name?");
             string UserFirstName = Console.ReadLine().ToLower();

            Console.WriteLine("what is your last name?");            
             string UserLastName = Console.ReadLine().ToLower();

            Console.WriteLine("what is your gender?");
            string UserGender = Console.ReadLine().ToLower();

            Console.WriteLine("what is your license number?");            
            string UserLNumber = Console.ReadLine().ToLower();


            dl FirstLastName = new dl();
            FirstLastName.FirstName = UserFirstName;
            FirstLastName.LastName = UserLastName;
            Console.WriteLine("{0} {1} is your full name",
                 FirstLastName.FirstName, FirstLastName.LastName 
                );
            Console.ReadLine();
        }

    }
    public class dl
    {
        public string FirstName;
        public string LastName;
        public string Gender;
        public string LNumber;
    }

}
