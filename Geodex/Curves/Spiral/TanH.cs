using System;

namespace Geodex.Curves.Spiral
{
    public class TanH : Curve
    {

        #region members

        public double A = 2.0;

        #endregion

        #region constructors

        public TanH() : base()
        {

        }

        public TanH(double t) : base()
        {
            this.T = t;
        }

        public TanH(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double u = (Math.Cos(A * s) + Math.Cosh(s));

            p.X = Math.Sinh(s) / u;
            p.Y = Math.Sin(A * s) / u;

        }

        #endregion

    }
}
