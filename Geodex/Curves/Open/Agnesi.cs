using System;

namespace Geodex.Curves.Open
{
    public class Agnesi : Curve
    {

        #region members

        public double A = 1.0;
        public double B = 5.0;

        #endregion

        #region constructors

        public Agnesi() : base()
        {

        }

        public Agnesi(double t) : base()
        {
            this.T = t;
        }

        public Agnesi(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * B;
            p.X = s;
            p.Y = (8.0 * Math.Pow(A, 3.0)) / (Math.Pow(s, 2) + 4.0 * Math.Pow(A, 2));

        }

        #endregion

    }
}
