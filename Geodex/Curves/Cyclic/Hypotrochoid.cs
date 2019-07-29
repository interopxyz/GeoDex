using System;

namespace Geodex.Curves.Cyclic
{
    public class Hypotrochoid : Curve
    {

        #region members

        public double A = 5.0;
        public double B = 2.0;

        #endregion

        #region constructors

        public Hypotrochoid() : base()
        {

        }

        public Hypotrochoid(double t) : base()
        {
            this.T = t;
        }

        public Hypotrochoid(double t, double a, double b) : base()
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
            double u = (A + B);
            double v = u/ B;

            p.X = u * Math.Cos(s) + B * Math.Cos(v * s);
            p.Y = u * Math.Sin(s) - B * Math.Sin(v * s);

        }

        #endregion

    }
}
