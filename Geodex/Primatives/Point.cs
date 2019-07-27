using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geodex
{
    public class Point
    {
        public double X = 0;
        public double Y = 0;
        public double Z = 0;

        public Point()
        {

        }

        public Point(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
            this.Z = point.Z;
        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = Y;
        }

        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = Y;
            this.Z = z;
        }


    }
}
