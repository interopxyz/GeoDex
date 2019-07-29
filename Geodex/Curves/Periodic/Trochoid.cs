using System;

namespace Geodex.Curves.Periodic
{
    public class Trochoid:Curve
    {

        #region members

        public double A = 1.0;
        public double B = 2.0;

        #endregion

        #region constructors

        public Trochoid() : base()
        {

        }
        public Trochoid(double t) : base()
        {
            this.T = t;
        }

        public Trochoid(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = A * s - B * Math.Sin(s);
            p.Y = A - B * Math.Cos(s);

        }

        #endregion

    }
}
