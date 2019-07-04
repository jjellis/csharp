using System;
using System.Collections.Generic;
using System.Text;

namespace todolist
{
    class App
    {
        itemrepostiory repo;
        
        public App()
        {
            repo = new itemrepostiory();
        }

        public void Start()
        {
            //display menu
           string action = ConsoleUtility.DisplayMenu().Getuserchoice();
            //process user actions
            while (action != "5")
            {
                //switch or else if, else if, else if, or if/break, if /break.
            if (action == "1")
                {
                  List<todoitems> list = repo.GetTodoitems();
                    ConsoleUtility.PrintTodoitem(list);
                    break;
                }
            if (action == "2")
                {
                    List<todoitems> list = repo.AddItem(string Description, string Status);
                    ConsoleUtility.PrintTodoitem(list);
                    break;
                }
                if (action == "3")
                {
                    List<todoitems> list = repo.UpdateItem(string Description, string Status);
                    ConsoleUtility.PrintTodoitem(list);
                    break;

                }
                if (action == "4")
                {
                    List<todoitems> list = repo.DeleteItem(int Id);
                    ConsoleUtility.PrintTodoitem(list);
                    break;
                }
                if (action == "6")
                {
                    List<todoitems> list = itemrepostiory.AskForinfo(itemstatus);
                    while(itemstatus !="done")
                    {ConsoleUtility.PrintTodoitem(list);
                    break;

                    }
                    
                }
                if (action == "7")
                {
                    List<todoitems> list = itemrepostiory.AskForinfo(itemstatus);
                    while (itemstatus == "done")
                    {
                        ConsoleUtility.PrintTodoitem(list);
                        break;

                    }
                }
            }
            //
        }
        public void ListItems()
        {
            repo.GetTodoitems();
        }
        public void AddItem(string descpt, string status, DateTime duedate)
        {
            repo.AddItem(descpt, status, duedate);
        }

        public void UpdateItem(int id, string descrip, string status, DateTime duedate)
        {
            repo.updateItem(id, descrip, status, duedate);
        }
         public void DeleteItem(int id)
        {
            repo.DeleteItem(id);
        }

}
