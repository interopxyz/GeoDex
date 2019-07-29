using System;

namespace Geodex.Curves.Open
{
    public class Logarithmic: Curve
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Logarithmic() : base()
        {

        }

        public Logarithmic(double t) : base()
        {
            this.T = t;
        }

        public Logarithmic(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = t;
            p.Y = A * Math.Log(t / B);

        }

        #endregion

    }
}
