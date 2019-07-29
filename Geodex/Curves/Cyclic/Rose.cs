using System;

namespace Geodex.Curves.Cyclic
{
    public class Rose : Curve
    {

        #region members

        public double A = 5.0;
        public double B = 3.0;

        #endregion

        #region constructors

        public Rose() : base()
        {

        }

        public Rose(double t) : base()
        {
            this.T = t;
        }

        public Rose(double t, double a, double b) : base()
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

            double u = Math.Cos(A / B * s);

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);

        }

        #endregion

    }
}
