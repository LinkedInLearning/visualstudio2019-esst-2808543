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

			var b = new Book();
			var book = new Book();
			book.Genre = Genre.Travel;
			book.Title = "Hiking the highroads in the Himalayas";
			book.Info.PageCount = 78;
			book.Info.Style = BookStyle.Paperback;


			string filePath = "C:\\demo.txt";

			// refactor the method name

			b.SaveBook(filePath, true, DateTime.Now);

			var b2 = new Book();
			b2.SaveBook(@"D:\otherfile.txt", false, DateTime.Now);

			// refactor the variable name
			// refactor the method name
			// explicit variable
			// wrap parameters
			// reorder parameters
			var p = new PaintLib.Calc();

			var litersProject1 = p.RectanglePaintLiters(coverageRatio: .85, width: 300, height: 140);
			var litersProject2 = p.EllipsePaintLiters(coverageRatio: .85,
																										majorAxisLength: 120,
																										minorAxisLength: 90);
			//
			var litersProject3 = p.CirlePaintLiters(radius: 230, coverageRatio: .85);
			
			var total = litersProject1 + litersProject2 + litersProject3;
			Console.WriteLine(total);
		}
	}
