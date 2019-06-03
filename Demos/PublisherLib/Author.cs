using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PublisherLib
{
 public class Author
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PenName { get; set; }
		public string FullName { get { return FirstName + " " + LastName; }  }

		public void AddBookToAuthor()
    { 
    
    }
  }
}
