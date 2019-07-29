using System;

namespace Geodex.Curves.Open
{
    public class CatenaryEqualStrength : Curve
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public CatenaryEqualStrength() : base()
        {

        }

        public CatenaryEqualStrength(double t) : base()
        {
            this.T = t;
        }

        public CatenaryEqualStrength(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI*A;

            p.X = s;
            p.Y = (-1 * A) * Math.Log(Math.Cos(s / A));

        }

        #endregion

    }
}
