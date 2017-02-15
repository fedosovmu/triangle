using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
	class Triangle
	{
		private Point a;
		private Point b;
		private Point c;
		private Edge edgeA;
		private Edge edgeB;
		private Edge edgeC;

		public Triangle(Point a, Point b, Point c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.edgeA = new Edge(this.b, this.c);
			this.edgeB = new Edge(this.a, this.c);
			this.edgeC = new Edge(this.a, this.b);
		}



		public double Perimeter
		{
			get
			{
				return this.edgeA.Length + this.edgeB.Length + this.edgeC.Length;
			}
		}



		public double Area
		{
			get
			{
				double p = this.Perimeter / 2;
				return Math.Sqrt(p * (p - this.edgeA.Length) * (p - this.edgeB.Length) * (p - this.edgeC.Length));
			}
		}



		public bool Right
		{	
			get
			{
				return ((Math.Pow(edgeA.Length, 2) + Math.Pow(edgeB.Length, 2) == Math.Pow(edgeC.Length, 2)) ||
					(Math.Pow(edgeA.Length, 2) + Math.Pow(edgeC.Length, 2) == Math.Pow(edgeB.Length, 2)) ||
					(Math.Pow(edgeB.Length, 2) + Math.Pow(edgeC.Length, 2) == Math.Pow(edgeA.Length, 2)));
			}
		}



		public bool Isosceles
		{
			get
			{
				return ((edgeA.Length == edgeB.Length && edgeA.Length != edgeC.Length) ||
					(edgeA.Length == edgeC.Length && edgeA.Length != edgeB.Length) ||
					(edgeC.Length == edgeB.Length && edgeC.Length != edgeA.Length));
			}
		}
	}
}
