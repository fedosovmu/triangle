using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
	class Edge
	{
		public readonly Point a;
		public readonly Point b;
		
		public Edge(Point a, Point b)
		{
			this.a = a;
			this.b = b;
		}


		public double Length
		{
			get
			{
				return Math.Sqrt( Math.Pow((this.a.x - this.b.x), 2) + Math.Pow((this.a.y - this.b.y), 2));
			}
		}

	}
}
