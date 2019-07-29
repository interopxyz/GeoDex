using System;

namespace Geodex.Curves.Cyclic
{
    public class CyclicHarmonic : Curve
    {

        #region members

        public double A = 1.0;
        public double B = 2.0;
        public double C = 0.5;

        #endregion

        #region constructors

        public CyclicHarmonic() : base()
        {

        }

        public CyclicHarmonic(double t) : base()
        {
            this.T = t;
        }

        public CyclicHarmonic(double t, double a, double b, double c) : base()
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

            double i = 1 + Math.E * A * Math.Cos(B * s);

            p.X = i * Math.Cos(s * C);
            p.Y = i * Math.Sin(s * C);

        }

        #endregion

    }
}
