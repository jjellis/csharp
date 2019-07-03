﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq

namespace todolist
{
    class itemrepostiory
    {
        itemcontext context; 
        public itemrepostiory()
        {
            context = new itemcontext();
            context.Database.EnsureCreated();
        }
        //list to do items
        public List<todoitems> GetTodoitems()
        {
            IEnumerable<todoitems> list = context.todoitem;
            return list.ToList();
        }
        public void AddItem(string descrition, string status, DateTime dueDate)
        {
            todoitems item = new todoitems(descrition, status, dueDate);
            context.todoitem.Add(item);
            context.SaveChanges();
        }
        public void AddItem(todoitems item)
        {

        }
        public void UpdateItem(int id, string newDescrip, string newStatus, string newDueDate) 
        {
            todoitems oldItem = context.todoitem.Where(item => x.Id == id).FirstOrDefault();

            ///todoitems oldItem = (from item in context.todoitem
            ///                     where item.Id == id
            ///                     select item).FirstOrDefault();
            ///                     
            oldItem.descrition = newDescrip;
            oldItem.Status = newStatus;
            oldItem.DueDate = newDueDate;
            context.Update(oldItem);
            context.SaveChanges();
        }

        public void updateItem(todoitems item)
        {

        }

        public void DeleteItem(int id)
        {
            todoitems oldItem = context.todoitem.Where(item => x.Id == id).FirstOrDefault();
            context.todoitems.Remove(oldItem);
            context.SaveChanges();

           

        }
    }
}
