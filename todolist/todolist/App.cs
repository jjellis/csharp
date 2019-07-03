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
        public void ListItems()
        {
            repo.GetTodoitems();
        }
        public void AddItem(string descpt, string status, DateTime duedate)
        {
            repo.AddItem(descpt, status, duedate);
        }

        public void UpdateItem(int id, string status, DateTime duedate)
        {
            repo.updateItem(id, descriptopn, staus, duedate);
        }
         public void DeleteItem(int id)
        {
            repo.DeleteItem(id);
        }

}
