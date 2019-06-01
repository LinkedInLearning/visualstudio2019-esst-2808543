using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharp
{
	class ExamplesHere
	{

		private long _sharedNumber;
		public void ExampleMethod()
		{
			long xFactor = 6;
			long yFactor = 123456789012345;
			double zFactor = 5.66;
			decimal qFactor = 5.66M;

			double total = AddNumbers(xFactor, yFactor);

			Console.WriteLine(zFactor);
			Console.WriteLine(qFactor);
			Console.WriteLine(total);
		}

		private long AddNumbers(long firstValue, long secondValue)
		{
			long total = firstValue + secondValue;
			_sharedNumber = firstValue;
			return total;
		}
	}
}
