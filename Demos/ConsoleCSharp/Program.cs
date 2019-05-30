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
