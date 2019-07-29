using System;

namespace Geodex.Curves.Other
{
    public class Hyperbola : Curve
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Hyperbola() : base()
        {

        }
        public Hyperbola(double t) : base()
        {
            this.T = t;
        }

        public Hyperbola(double t, double a, double b) : base()
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

            p.X = A * (1 / Math.Cos(s));
            p.Y = B * Math.Tan(s);

        }

        #endregion

    }
}
