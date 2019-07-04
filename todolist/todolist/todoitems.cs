using System;
using System.Collections.Generic;
using System.Text;

namespace todolist
{
    class todoitems
    {
        public int Id { get; private set; }
    public string Description { get; set; }
        public string Status { get; set; }

        public todoitems(int Id, string Description, string status)
        {
            this.Description = Description;
            this.Status = status;
        }
    }
}
