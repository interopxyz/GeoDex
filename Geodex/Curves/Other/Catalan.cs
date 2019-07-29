using System;

namespace Geodex.Curves.Other
{
    public class Catalan : Curve
    {

        #region members

        public double A = 2.0;

        #endregion

        #region constructors

        public Catalan() : base()
        {

        }

        public Catalan(double t) : base()
        {
            this.T = t;
        }

        public Catalan(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = A / (1 - Math.Pow(s, 2));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
