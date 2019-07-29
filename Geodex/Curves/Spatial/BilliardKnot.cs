using System;

namespace Geodex.Curves.Spatial
{
    public class BilliardKnot : Curve
    {

        #region members

        public double A = 3.0;
        public double B = 8.0;
        public double C = 1.0;

        #endregion

        #region constructors

        public BilliardKnot() : base()
        {

        }

        public BilliardKnot(double t) : base()
        {
            this.T = t;
        }

        public BilliardKnot(double t, double a, double b, double c) : base()
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

            double i = Math.Sqrt(1 + Math.Pow(C, 2) * Math.Pow(Math.Sin(B * s), 2));

            p.X = (Math.Cos(A * s)) / i;
            p.Y = (Math.Sin(A * s)) / i;
            p.Z = (Math.Sin(B * s)) / i;

        }

        #endregion

    }
}
