using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PublisherLib.Data
{
	public class BookDataSource
	{
		private Random _random = new Random();
		private readonly List<Book> _books;

		public BookDataSource()
		{
			var xmlDoc = XDocument.Load("BookList.xml");
			var list = xmlDoc.Root.Elements("Book").ToList();
			Author author;
			_books = new List<Book>();
			foreach (var item in list)
			{
				author = new Author
				{
					FirstName = item.Element("Author").Element("FirstName").Value,
					LastName = item.Element("Author").Element("LastName").Value
				};
				_books.Add(new Book
				{
					Author = author,
					Title = item.Element("Title").Value,
					Price = Decimal.Parse(item.Element("Price").Value),
					CopiesSold = int.Parse(item.Element("CopiesSold").Value),
					PublicationDate = DateTime.Parse(item.Element("PublicationDate").Value)

				}); ;
			}
		}
		public Book GetRandomBook()
		{
			return _books.ElementAt(_random.Next(_books.Count()));
		}

		public Book GetBestSellingBook()
		{
			var topCount = _books.Max(x => x.CopiesSold);
			return _books.First(x => x.CopiesSold ==topCount);
		}
		public List<Book> GetAllBooks() {

			return _books;
		}
	}
}
