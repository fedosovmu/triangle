using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
	class Edge
	{
		public readonly Point A;
		public readonly Point B;
		
		public Edge(Point a, Point b)
		{
			this.A = a;
			this.B = b;
		}



		public double Length
		{
			get
			{
				return Math.Sqrt( Math.Pow((this.A.X - this.B.X), 2) + Math.Pow((this.A.Y - this.B.Y), 2));
			}
		}



        public static bool operator == (Edge e1, Edge e2)
        {
            return (e1.A == e2.A) && (e1.B == e2.B);
        }


        public static bool operator != (Edge e1, Edge e2)
        {
            return !(e1 == e2);
        }

	}
}
