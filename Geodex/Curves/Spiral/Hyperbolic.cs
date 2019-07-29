using System;

namespace Geodex.Curves.Spiral
{
    public class Hyperbolic : Curve
    {

        #region members

        public double A = 1;

        #endregion

        #region constructors

        public Hyperbolic() : base()
        {

        }

        public Hyperbolic(double t) : base()
        {
            this.T = t;
        }

        public Hyperbolic(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double u = A / t;

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);

        }

        #endregion

    }
}
