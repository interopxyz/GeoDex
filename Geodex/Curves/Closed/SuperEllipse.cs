using System;

namespace Geodex.Curves.Closed
{
    public class SuperEllipse : Curve
    {

        #region members

        public double A = 2.0;
        public double B = 1.0;
        public double C = 0.5;

        #endregion

        #region constructors

        public SuperEllipse() : base()
        {

        }

        public SuperEllipse(double t) : base()
        {
            this.T = t;
        }

        public SuperEllipse(double t, double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = Math.Pow(Math.Abs(Math.Cos(s)), (2 / C)) * A * Math.Sign(Math.Cos(s));
            p.Y = Math.Pow(Math.Abs(Math.Sin(s)), (2 / C)) * B * Math.Sign(Math.Sin(s));

        }

        #endregion

    }
}
