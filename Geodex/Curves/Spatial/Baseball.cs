using System;

namespace Geodex.Curves.Spatial
{
    public class Baseball : Curve
    {

        #region members

        public double A = 1.0;
        public double B = 0.5;

        #endregion

        #region constructors

        public Baseball() : base()
        {

        }

        public Baseball(double t) : base()
        {
            this.T = t;
        }

        public Baseball(double t, double a, double b) : base()
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


            p.X = A * Math.Cos(s) + B * Math.Cos(3 * s);
            p.Y = A * Math.Sin(s) - B * Math.Sin(3 * s);
            p.Z = (2 * Math.Sqrt(A * B)) * Math.Sin(2 * s);

        }

        #endregion

    }
}
