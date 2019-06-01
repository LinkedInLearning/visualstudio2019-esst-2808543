using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharp
{
	class ExamplesHere
	{
		

		public void ExampleMethod()
		{
			// Show ListMembers
			// AKA Auto Complete
			// Ctrl-J



			// Finish auto-complete with
			// Mouse, Tab, Spacebar, Parenthesis, Semicolon



			// Fix issues with code with Ctrl-Spacebar
			// AKA CompleteWord

			var currentBook = new Book
			{
				Title = "Hiking the hills...",
				Price = 29.95M
			};


			// Use Parameter Info to show information
			// Ctrl-Shift-Spacebar


			Console.Writine(currentBook.Title);
			currentBook.SaveBook();




		}
	}
}
