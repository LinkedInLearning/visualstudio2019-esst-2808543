using System;
using System.Collections.Generic;

namespace ConsoleCSharp
{
	class ExamplesHere
	{

		public void UseFormatDocument()
		{
			var bookList = new List<string>();
			var authorList = new List<string>();

			bookList.Add("Hiking the hills");
			authorList.Add("Walt Ritscher");
			var isPremiumCustomer = true;

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
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}
		}


	}
}
