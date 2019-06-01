using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavigatingCSharp
{
	class Book
	{
		public string BookName { get; set; }
		public string Author { get; set; }
		public string ISBN { get; set; }
		public decimal RoyaltyPercent { get; set; }

		const Decimal MAX_PRICE = 120;
		private decimal _price;
		internal void UpdatePrice(int BookID, decimal newPrice)
		{

			if (newPrice < 0)
			{
				_price = newPrice;
			}

			// call another method
			Console.WriteLine("Done");
			_price = CapPriceAtMaximum(newPrice);
		}

		/// <summary>
		///  Cap a book price
		/// </summary>
		/// <param name="currentPrice">new book price</param>
		/// <returns></returns>
		private decimal CapPriceAtMaximum(decimal currentPrice)
		{
			// use the private field
			_price = 100M;

			if (currentPrice > 120M)
			{
				return 120M;
			}
			else
			{
				return currentPrice;
			}


		}
	}
}
