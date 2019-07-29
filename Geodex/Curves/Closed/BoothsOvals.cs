using System;

namespace Geodex.Curves.Closed
{
    public class BoothsOvals : Curve
    {

        #region members

        public double A = 0.25;
        public double B = 1.0;

        #endregion

        #region constructors

        public BoothsOvals() : base()
        {

        }

        public BoothsOvals(double t) : base()
        {
            this.T = t;
        }

        public BoothsOvals(double t, double a, double b) : base()
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

            double i = (Math.Pow(B, 2) * Math.Pow(Math.Cos(s), 2) + Math.Pow(A, 2) * Math.Pow(Math.Sin(s), 2));

            p.X = B * ((A * B * Math.Cos(s)) / i);
            p.Y = A * ((A * B * Math.Sin(s)) / i);

        }

        #endregion

    }
}