using System;

namespace DebugConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			// Spelling errrs in comments are flaged

			string description = "Errors in strings are alos discovered.  ";

			// variable names and other code members are not
			// spell checked
			var demonstrtion = 4;
		  
			Console.WriteLine(description);
			Console.WriteLine(demonstrtion);
		}
	}
}
