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

			Point a1 = new Point(0, 0); // Равнобедренный (площадь 40)
			Point b1 = new Point(10, 0);
			Point c1 = new Point(5, 8);

			Point a2 = new Point(0, 0); // Прямоугольный (периметр 12)
			Point b2 = new Point(0, 3);
			Point c2 = new Point(4, 0);

			Point a3 = new Point(0, 0); // Произвольный
			Point b3 = new Point(7, 8);
			Point c3 = new Point(4, 5);

			Point a4 = new Point(2, 7); // Прямоугольный и Равнобедренный (периметр 15.27, площадь 10)
			Point b4 = new Point(4, 1);
			Point c4 = new Point(6, 5);

			Point a5 = new Point(0, 0); // Равнобедеренный (площадь 20)
			Point b5 = new Point(0, 8);
			Point c5 = new Point(5, 4);

			Point a6 = new Point(10, 0); // Вырожденный
			Point b6 = new Point(10, 10);
			Point c6 = new Point(10, 20);

			Triangle[] triangleArray = new Triangle[]
			{
				new Triangle(a1, b1, c1),
				new Triangle(a2, b2, c2),
				new Triangle(a3, b3, c3),
				new Triangle(a4, b4, c4),
				new Triangle(a5, b5, c5),
				//new Triangle(a6, b6, c6) //<-- Вырожденный треугольник
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


            if (triangleArray[1] == triangleArray[1])
                Console.WriteLine("Треугольник A == треугольнику B");
            else
                Console.WriteLine("Треугольник A != треугольнику B");



			var triangle = new Triangle(a1, b1, c1);
			Console.WriteLine("perimeter = " + triangle.Perimeter + " area = " + triangle.Area);

            var nAngle = new NAngle(a1, b1, c1);
			Console.WriteLine("Периметр многоугольника " + nAngle.Perimeter);
			Console.WriteLine("Площадь многоугольника " + nAngle.Area);


			Console.ReadKey();
		}
	}
}
