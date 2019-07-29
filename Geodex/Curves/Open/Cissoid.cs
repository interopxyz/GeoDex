using System;

namespace Geodex.Curves.Open
{
    public class Cissoid : Curve
    {

        #region members

        public double A = 0.0;

        #endregion

        #region constructors

        public Cissoid() : base()
        {

        }

        public Cissoid(double t) : base()
        {
            this.T = t;
        }

        public Cissoid(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t*Math.PI;

            p.Y = Math.Pow(s * Math.Cos(A / 2) - Math.Sin(A / 2), 2) / (1 + Math.Pow(s, 2));
            p.X = s * p.Y;

        }

        #endregion

    }
}
