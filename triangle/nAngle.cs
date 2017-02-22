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



        public NAngle(Point[] Points) // <-- здесь должен быть params
        {
            if (Points.Length < 3)
                throw new ArgumentException("В многоугольнике должно быть хотябы 3 точки");
            this.Points = Points;
        }

        // <- Уже конец пары, Доделаю вечеров

    }
}
