using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCSharp
{
  public class Book : Document{
    // classes contain data and code
    public string Title { get; set; }
    public decimal Price { get; set; }
		public Genre Genre { get; set; }
		public BookInfo Info { get; set; }

		public long GetWordCount() {
            // comments 
            return 42;
    }
    public void SaveBook() {
      // comments 
      
    }
  }

  public class BookInfo {
    // structs are primarily for data stores
    public int PageCount { get; set; }
    public BookStyle Style { get; set; }

    public event EventHandler<EventArgs> SizeChanged;
  }


	public enum BookStyle
	{
		Paperback,
		Hardcover,
		eBook

	}
	public enum Genre
	{
		None = 0,
		Cooking,
		Science,
		Biographies,
		History,
		Art,
		Reference,
		Travel

	}
}