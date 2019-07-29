using System;

namespace Geodex
{
    public class Point
    {

        #region members

        public double X = 0;
        public double Y = 0;
        public double Z = 0;

        #endregion

        #region constructor

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

        #endregion

        #region properties

        #endregion

        #region methods

        #endregion

    }
}
