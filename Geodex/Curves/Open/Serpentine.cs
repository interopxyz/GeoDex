using System;

namespace Geodex.Curves.Open
{
    public class Serpentine : Curve
    {

        #region members

        public double A = 0.25;
        public double B = 1.0;

        #endregion

        #region constructors

        public Serpentine() : base()
        {

        }

        public Serpentine(double t) : base()
        {
            this.T = t;
        }

        public Serpentine(double t, double a, double b) : base()
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
            p.Y = (A * B * t) / (Math.Pow(t, 2) + Math.Pow(A, 2));

        }

        #endregion

    }
}
