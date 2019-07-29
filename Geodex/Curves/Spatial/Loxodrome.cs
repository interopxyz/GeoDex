using System;

namespace Geodex.Curves.Spatial
{
    public class Loxodrome : Curve
    {

        #region members

        public double A = 3.0;

        #endregion

        #region constructors

        public Loxodrome() : base()
        {

        }

        public Loxodrome(double t) : base()
        {
            this.T = t;
        }

        public Loxodrome(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = s / A;

            p.X = Math.Cos(s) / Math.Cosh(i);
            p.Y = Math.Sin(s) / Math.Cosh(i);
            p.Z = Math.Tanh(i);

        }

        #endregion

    }
}
