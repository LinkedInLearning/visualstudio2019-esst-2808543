using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharp
{
	class ExamplesHere
	{

	
		public void ExampleMethod()
		{
			// comments 
			var book = new Book();
			book.Genre = Genre.Travel;
			book.Title = "Hiking the highroads in the Himalayas";
			book.Info.PageCount = 78;
			book.Info.Style = BookStyle.Paperback;

			// matching braces
			if (true)
			{
				for (int i = 0; i < 3; i++)
				{
					switch (i)
					{
						default:
							break;
					}
				}
			}
		}
	}
}
