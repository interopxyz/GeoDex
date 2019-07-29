using System;

namespace Geodex.Curves.Closed
{
    public class Circle : Curve
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public Circle() : base()
        {

        }

        public Circle(double t) : base()
        {
            this.T = t;
        }

        public Circle(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = A*Math.Cos(s);
            p.Y = A * Math.Sin(s);

        }

        #endregion

    }
}
