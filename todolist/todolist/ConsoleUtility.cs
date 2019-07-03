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
                    " l: list all items" +
                    " a: add a new item" +
                    " u: update an item" +
                    " d: delete an item" +
                    " q: quit the program";
            Console.WriteLine(menu);
    }
        public void ProcessInput(UserChoice choice)
        {
            while(choice. != UserChoice.Quit)
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
            Quit
        }
    }
}
