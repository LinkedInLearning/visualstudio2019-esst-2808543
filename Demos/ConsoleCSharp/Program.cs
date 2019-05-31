using System;

namespace ConsoleCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			// the canonical sample code for a new program! (HELLO WORLD)
			Console.WriteLine("Hello World!");
		}

		private void CommentExample()
		{
			// An example of  long, rambling comment that explains why this code is necessary for our core sales application. DO NOT REMOVE the code in this method. Do not change this code without approval. You've been warned. You might think you are improving the code.  You are not! Do not remove. 
		}
	}

	// this enum should be declared in a separate file
	public enum TourType
	{
		None = 0,
		Walking,
		Food,
		Bicycle,
		Sailing,
		Cruise

	}
}
