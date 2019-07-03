using System;
using System.Collections.Generic;
using System.Text;

namespace BookInventory
{
    class BookInventory
    {
        
            // notice the private set on the id
            public int Id { get; private set; }
            public String BookName { get; set; }
            public String AuthorName { get; set; }
            public BookInventory(String bookname, String authorname)
            {
                this.BookName = bookname;
                this.AuthorName = authorname;
            }
        
    }
}
