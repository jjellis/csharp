using System;
using System.Collections.Generic;
using System.Text;

namespace todolist
{
    class ConsoleUtility {
        App app;
        public ConsoleUtility()
        {
            app = new App();
        }
        public void DisplayMenu()
    {
            string menu = "TODO app, choose an option" +
                    " 1: list all items" +
                    " 2: add a new item" +
                    " 3: update an item" +
                    " 4: delete an item" +
                    " 5: quit the program" +
                    "6: list pending items" +
                    "7: list done items";
                    
            Console.WriteLine(menu);
    }
        public string Getuserchoice()
        {
            Console.WriteLine("what do you want to do");
            string action = Console.ReadLine();
            return action;
        }
        //public stating string printmenu()
        //{

        //}
        public void ProcessInput(UserChoice choice)
        {
            while(choice != UserChoice.Quit)
            {
                switch (choice)
                {
                    case UserChoice.ListItem:
                        app.ListItems();
                        break;

                    case UserChoice.AddItem:
                        Console.WriteLine("enter descriptopn, status, and due date");
                        break;

                }
            }
        }

    
        public enum UserChoice{
            ListItem,
            AddItem,
            UpdateItem,
            DeleteItem,
            Quit,
            Pending,
            Done
        }
        public static void PrintTodoitem(List<todoitems> list)
        {
            foreach(todoitems item in list)
            {
                Console.WriteLine($"{item.Id} - {item.Description} - {item.Status}");
            }
        }
        public static string AskForinfo()
        {
            Console.WriteLine("enter item description");
            string itemdes = Console.ReadLine();
            Console.WriteLine("enter item duedate");
            string itemdate = Console.ReadLine();
            string iteminfo = (itemdes + itemdate);
            return iteminfo;
            
        }
        public static int GetItemID()
        {
            Console.WriteLine("enter id of item:");
            string userinput = Console.ReadLine();
            int itemID = int.Parse(userinput);
            return itemID;
        }
    }
}
