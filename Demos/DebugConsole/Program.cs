using System;

namespace DebugConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			// Spelling errs in comments are flagged

			string description = "Errors in strings are also discovered.  ";

			// variable names and other code members are not
			// spell checked
			var demonstrtion = 4;
		  
			Console.WriteLine(description);
			Console.WriteLine(demonstrtion);
		}
	}
}
