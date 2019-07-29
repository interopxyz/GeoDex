using System;

namespace Geodex.Curves.Spiral
{
    public class Coth : Curve
    {

        #region members

        public double A = 4.0;

        #endregion

        #region constructors

        public Coth() : base()
        {

        }

        public Coth(double t) : base()
        {
            this.T = t;
        }

        public Coth(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double u = Math.Cos(2 * A * s) - Math.Cosh(2 * s);

            p.X = (-1) * Math.Sinh(2 * s) / u;
            p.Y = Math.Sin(2 * A * s) / u;

        }

        #endregion

    }
}
