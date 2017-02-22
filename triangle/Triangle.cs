using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
	class Triangle
	{
		public readonly Point A;
		public readonly Point B;
		public readonly Point C;
		public Edge edgeA
		{
			get { return new Edge(this.B, this.C); }
		}
		public Edge edgeB
		{
			get { return new Edge(this.A, this.C); }
		}
		public Edge edgeC
		{
			get { return new Edge(this.A, this.B); }
		}



		public Triangle(Point a, Point b, Point c)
		{
			this.A = a;
			this.B = b;
			this.C = c;
		
			
			if ((this.edgeA.Length + this.edgeB.Length <= this.edgeC.Length)
				|| (this.edgeB.Length + this.edgeC.Length <= this.edgeA.Length)
				|| (this.edgeA.Length + this.edgeC.Length <= this.edgeB.Length))
				throw new ArgumentException("Вырожденный треугольник");
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



        public static bool operator == (Triangle t1, Triangle t2)
        {
            return (t1.A == t2.A) && (t1.B == t2.B) && (t1.C == t2.C);
        }



        public static bool operator != (Triangle t1, Triangle t2)
        {
            return !(t1 == t2);
        }
	}
}
