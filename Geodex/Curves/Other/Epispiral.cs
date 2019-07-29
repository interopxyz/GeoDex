using System;

namespace Geodex.Curves.Other
{
    public class Epispiral : Curve
    {

        #region members

        public double A = 2.0;

        #endregion

        #region constructors

        public Epispiral() : base()
        {

        }
        public Epispiral(double t) : base()
        {
            this.T = t;
        }

        public Epispiral(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;
            double i = 1 / Math.Cos(A * s);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
