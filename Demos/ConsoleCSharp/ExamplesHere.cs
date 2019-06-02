using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharp
{
	class ExamplesHere
	{
		// classes contain data and code
		public string Title { get; set; }
		public decimal Price { get; set; }
		public int MyProperty { get; set; }
		private int myVar;

		public int MyProperty2
		{
			get { return myVar; }
			set { myVar = value; }
		}

		public ExamplesHere() {

		}

		public void ExampleMethod()
		{

			// use the Ctrl-K, Ctrl-X combo to see the big list of snippets
			Console.WriteLine();
			for (int counter = 0; counter < 10; counter++)
			{

			}
			for (int counter = 30 - 1; counter >= 0; counter--)
			{

			}
		}
	}
}
