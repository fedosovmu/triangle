using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class NAngle
    {
        public Point[] Points;



        public NAngle(params Point[] Points) // <-- здесь должен быть params
        {
            if (Points.Length < 3)
                throw new ArgumentException("В многоугольнике должно быть хотябы 3 точки");
            this.Points = Points;
        }


        // <- Уже конец пары, Доделаю вечеров
        public double Perimeter
        {
            get 
            { 
                double perimeter = 0;
                for (int i = 0; i < Points.Length - 1; i++)
                {
                    var edge = new Edge(Points[i], Points[i + 1]);
                    perimeter += edge.Length;
                }
                return perimeter; 
            }
        }



        public double Area
        {
            get
            {
                for (int i = 0; i < )

                return 0;
            }
        }
    }
}
