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

		public void ExampleMethod()
		{

			// refactor the variable name
			// refactor the method name
			// explicit variable
			// wrap parameters
			// reorder parameters
			var p = new PaintLib.Calc();

			var litersProject1 = p.RectangleLiters(coverageRatio: .85, width: 300, height: 140);
			var litersProject2 = p.EllipsePaintLiters(coverageRatio: .85,
																										majorAxisLength: 120,
																										minorAxisLength: 90);
			//
			var litersProject3 = p.CircleLiters(coverageRatio: .85, radius: 230);
			
			var total = litersProject1 + litersProject2 + litersProject3;
			Console.WriteLine(total);
		}
	}
