using System;

namespace Geodex.Curves.Other
{
    public class Conchoid : Curve
    {

        #region members

        public double A = 2.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Conchoid() : base()
        {

        }

        public Conchoid(double t) : base()
        {
            this.T = t;
        }

        public Conchoid(double t, double a, double b) : base()
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
            double i = A + B * (1 / Math.Cos(s));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
