using System;

namespace Geodex.Curves.Closed
{
    public class Lissajous : Curve
    {

        #region members

        public double A = 5.0;
        public double B = 3.0;
        public double C = 0.5;

        #endregion

        #region constructors

        public Lissajous() : base()
        {

        }

        public Lissajous(double t) : base()
        {
            this.T = t;
        }

        public Lissajous(double t, double a, double b, double c) : base()
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

            p.X = Math.Sin(A * 2 * s + C * Math.PI);
            p.Y = Math.Sin(B * 2 * s);

        }

        #endregion

    }
}
