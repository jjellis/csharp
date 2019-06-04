using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            List<ToDoItem> todolist = new List<ToDoItem>();
            ToDoItem toAdd = new ToDoItem();
            
                
            while (answer != "no")//loop things
            {
                

                string question = "add to the to do list? yes or no?";
            Console.WriteLine(question);
             answer = Console.ReadLine().ToLower();
               if (answer == "no")
            {
                    break;
            }
                Console.WriteLine("what do you need to do?");
                string description = Console.ReadLine().ToLower();
                Console.WriteLine(toAdd.description);
                             

                Console.WriteLine("When does it need to be done?");
                string date = Console.ReadLine().ToLower();
                Console.WriteLine(toAdd.date);

                Console.WriteLine("what is the priority: high, medium, low?");
                string priority = Console.ReadLine().ToLower();
                Console.WriteLine(toAdd.priority);
                toAdd.description = description;
             
                
            }

            foreach (ToDoItem item in todolist)//idk add things 
                Console.WriteLine(toAdd.toStr());
            {
            }

        }
        class ToDoItem
        {
            //description 
            public string description { get; set; }

            //priority
            public string priority { get; set; }

            //date
            public string date { get; set; }

            //2. instantiate to do item object
            //todoitem myItem = new (descrption, due date, priorty)
            public ToDoItem(string desc, string due, string pri)
            {
                this.description = desc;
                this.date = due;
                this.priority = pri;
            }

            public ToDoItem()
            {
           /* public string description;
            public string date;
            public string priority;*/

        }

            public string toStr()
            {
                return  description +" "+ date + " " + priority;
            }
            //3. add myitem to your list
            //list<todoitem> mylist = new(items)
        }
    }
}
//ctr tab tab constrictor 