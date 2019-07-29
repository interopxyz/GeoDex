using System;

namespace Geodex.Curves.Other
{
    public class Conchal : Curve
    {

        #region members

        public double A = 2.0;
        public double B = 2.0;

        #endregion

        #region constructors

        public Conchal() : base()
        {

        }

        public Conchal(double t) : base()
        {
            this.T = t;
        }

        public Conchal(double t, double a, double b) : base()
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

            p.X = s;
            p.Y = (Math.Sqrt((Math.Pow(B, 2) + Math.Pow(A, 2) - Math.Pow(s, 2)) * (Math.Pow(B, 2) - Math.Pow(A, 2) + Math.Pow(s, 2))) / (s + A));

        }

        #endregion

    }
}
