using System;

namespace Geodex.Curves.Closed
{
    public class Plateau : Curve
    {

        #region members

        public double A = 1.25;
        public double B = 1.0;

        #endregion

        #region constructors

        public Plateau() : base()
        {

        }
        public Plateau(double t) : base()
        {
            this.T = t;
        }

        public Plateau(double t, double a, double b) : base()
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

            p.X = Math.Sin((A + B) * s) / Math.Sin((A - B) * s);
            p.Y = 2 * Math.Sin(A * s) * Math.Sin(B * s) / Math.Sin((A - B) * s);

        }

        #endregion

    }
}
