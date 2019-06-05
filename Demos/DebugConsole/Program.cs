using System;

namespace DebugConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			// Spelling errrs in comments are flaged

			string description = "Errors in strings are alos discovered.  ";

			// what about variable names?

			var demonstrtion = 4;

			Console.WriteLine(description);
			Console.WriteLine(demonstrtion);
		}
	}
}
