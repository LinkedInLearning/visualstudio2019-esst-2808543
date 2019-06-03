using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSellerConsole
{
	class Program
	{
		static void Main(string[] args)
		{

			var dataSource = new PublisherLib.BookDataSource();
			PublisherLib.Book book = dataSource.GetBestSellingBook();
			Console.WriteLine($"Title: {book.Title}, Copies Sold:{book.CopiesSold}");
		}
	}
}
