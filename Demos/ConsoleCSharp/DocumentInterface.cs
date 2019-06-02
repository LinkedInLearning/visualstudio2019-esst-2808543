using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharp
{
	interface Document
	{

		string Title { get; set; }
		string Publisher { get; set; }
	}

	public class Book : Document
	{
		
		public string Title { get; set; }
		public string Publisher { get; set; }
	}
}
