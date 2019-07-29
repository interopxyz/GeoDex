using System;

namespace Geodex.Curves.Other
{
    public class HippiasQuadratrix : Curve
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public HippiasQuadratrix() : base()
        {

        }
        public HippiasQuadratrix(double t) : base()
        {
            this.T = t;
        }

        public HippiasQuadratrix(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = 2 * A * s / (Math.PI * Math.Sin(s));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}