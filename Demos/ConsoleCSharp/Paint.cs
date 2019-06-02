using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharp.PaintLib
{

	public class Calc
	{
		// For real project use  Math.PI 
		// refactor constant for PI
		const double AREA_PER_RATIO = 750;
		private const double PI = 3.141592;

		public double RectangleLiters(double coverageRatio, double width, double height)
		{
			var area = width * height;
			return (area / AREA_PER_RATIO) * coverageRatio;
		}
		public double EllipsePaintLiters(double coverageRatio, double majorAxisLength, double minorAxisLength)
		{
			var area = PI * (majorAxisLength * minorAxisLength);
			return (area / AREA_PER_RATIO) * coverageRatio;
		}

		public double CircleLiters(double coverageRatio, double radius) {
			var area = GetArea(radius);
			return (area / AREA_PER_RATIO) * coverageRatio;
		}

		private static double GetArea(double radius) {
			return PI * (radius * radius);
		}
	}

}

