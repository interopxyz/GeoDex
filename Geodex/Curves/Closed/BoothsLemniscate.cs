using System;

namespace Geodex.Curves.Closed
{
    public class BoothsLemniscate : Curve
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public BoothsLemniscate() : base()
        {

        }

        public BoothsLemniscate(double t) : base()
        {
            this.T = t;
        }

        public BoothsLemniscate(double t, double a, double b) : base()
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


            double i = 1 + (Math.Pow(A, 2) / Math.Pow(B, 2)) * Math.Pow(Math.Cos(s), 2);

            p.X = B * (Math.Sin(s) / i);
            p.Y = A * ((Math.Sin(s) * Math.Cos(s)) / i);

        }

        #endregion

    }
}