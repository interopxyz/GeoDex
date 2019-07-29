using System;

namespace Geodex.Curves.Closed
{
    public class Limacon : Curve
    {

        #region members

        public double A = 2.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Limacon() : base()
        {

        }

        public Limacon(double t) : base()
        {
            this.T = t;
        }

        public Limacon(double t, double a, double b) : base()
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

            double u = B + A * Math.Cos(s);

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);

        }

        #endregion

    }
}
