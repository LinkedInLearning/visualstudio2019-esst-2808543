using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharp.PaintLib
{

	public class Calc
	{
		// For real project use  Math.PI 
		// refactor constant for PI
		const double areaperratio = 750;

		public double RectanglePaintLiters(double coverageRatio, double width, double height)
		{
			var area = width * height;
			return (area / areaperratio) * coverageRatio;
		}
		public double EllipsePaintLiters(double coverageRatio, double majorAxisLength, double minorAxisLength)
		{
			var area = 3.141592 * (majorAxisLength * minorAxisLength);
			return (area / areaperratio) * coverageRatio;
		}

		public double CirlePaintLiters(double radius, double coverageRatio)
		{
			var area = 3.141592 * (radius * radius);
			return (area / areaperratio) * coverageRatio;
		}
	}

}

