using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharp
{
	interface IDocument
	{

		string Title { get; set; }
		string Publisher { get; set; }
	}

	public class Book : IDocument
	{
		
		public string Title { get; set; }
		public string Publisher { get; set; }
	}
}
