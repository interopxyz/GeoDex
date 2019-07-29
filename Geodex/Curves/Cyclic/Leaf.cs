using System;

namespace Geodex.Curves.Cyclic
{
    public class Leaf : Curve
    {

        #region members

        public double A = 5.0;
        public double B = 2.0;
        public double C = 4.5;

        #endregion

        #region constructors

        public Leaf() : base()
        {

        }

        public Leaf(double t) : base()
        {
            this.T = t;
        }

        public Leaf(double t, double a, double b, double c) : base()
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

            double u = A + B * Math.Cos(C * s);

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);

        }

        #endregion

    }
}
