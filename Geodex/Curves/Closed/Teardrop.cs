using System;

namespace Geodex.Curves.Closed
{
    public class Teardrop : Curve
    {

        #region members

        public double A = 4.0;

        #endregion

        #region constructors

        public Teardrop() : base()
        {

        }

        public Teardrop(double t) : base()
        {
            this.T = t;
        }

        public Teardrop(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = Math.Cos(s);
            p.Y = Math.Sin(s) * Math.Pow(Math.Sin(s / 2), A);

        }

        #endregion

    }
}
