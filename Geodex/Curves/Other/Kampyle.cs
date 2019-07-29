using System;

namespace Geodex.Curves.Other
{
    public class Kampyle : Curve
    {

        #region members

        public double A = 1.0;
        public double B = 2.0;

        #endregion

        #region constructors

        public Kampyle() : base()
        {

        }

        public Kampyle(double t) : base()
        {
            this.T = t;
        }

        public Kampyle(double t, double a, double b) : base()
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

            double i = Math.Pow(B, 2) / (A * Math.Pow(Math.Cos(s), 2));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
