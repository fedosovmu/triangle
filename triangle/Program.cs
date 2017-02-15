using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Привет");

			Point x1 = new Point(0, 0); // Равнобедренный (площадь 40)
			Point y1 = new Point(10, 0);
			Point z1 = new Point(5, 8);

			Point x2 = new Point(0, 0); // Прямоугольный (периметр 12)
			Point y2 = new Point(0, 3);
			Point z2 = new Point(4, 0);

			Point x3 = new Point(0, 0); // Произвольный
			Point y3 = new Point(7, 8);
			Point z3 = new Point(4, 5);

			Point x4 = new Point(2, 7); // Прямоугольный и Равнобедренный (периметр 15.27, площадь 10)
			Point y4 = new Point(4, 1);
			Point z4 = new Point(6, 5);

			Point x5 = new Point(0, 0); // Равнобедеренный (площадь 20)
			Point y5 = new Point(0, 8);
			Point z5 = new Point(5, 4);

			Triangle[] triangleArray = new Triangle[]
			{
				new Triangle(x1, y1, z1),
				new Triangle(x2, y2, z2),
				new Triangle(x3, y3, z3),
				new Triangle(x4, y4, z4),
				new Triangle(x5, y5, z5),
			};

			double avgPerimetr = 0;
			double avgArea = 0;

			int countRight = 0;
			int countIs = 0;

			for (int i = 0; i < triangleArray.Length; i++)
			{
				if (triangleArray[i].Right)
				{
					avgPerimetr += triangleArray[i].Perimeter;
					countRight++;
				}

				if (triangleArray[i].Isosceles)
				{
					avgArea += triangleArray[i].Area;
					countIs++;
				}
			}

			if (countRight != 0)
				avgPerimetr /= countRight;

			if (countIs != 0)
				avgArea /= countIs;

			Console.WriteLine("Средний периметр: {0:F2}", avgPerimetr);
			Console.WriteLine("Средняя площадь: {0:F2}", avgArea);


			Console.ReadKey();
		}
	}
}
