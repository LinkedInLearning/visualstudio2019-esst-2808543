using System;
using System.Collections.Generic;

namespace ConsoleCSharp
{
	class ExamplesHere
	{
		private int bookCount;

		public void UseFormatDocument()
		{
			var bookList = new List<string>();
			List<string> authorList = new List<string>();

			bool isPremiumCustomer = true;

			// with braces
			if (isPremiumCustomer)
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}

			// without braces
			if (isPremiumCustomer)
				Console.WriteLine("true");
			else
				Console.WriteLine("false");


		}

		public void DefaultCSharpRules()
		{


		}
	}
}
