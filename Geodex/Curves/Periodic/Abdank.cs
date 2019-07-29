using System;

namespace Geodex.Curves.Periodic
{
    public class Abdank : Curve
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public Abdank() : base()
        {

        }

        public Abdank(double t) : base()
        {
            this.T = t;
        }

        public Abdank(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = A * Math.Sin(s);
            p.Y = (Math.Pow(A, 2) / 2) * (s + Math.Sin(s) * Math.Cos(s));

        }

        #endregion

    }
}
