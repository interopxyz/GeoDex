using System;

namespace Geodex.Curves.Cyclic
{
    public class Hypocycloid_B : Curve
    {

        #region members

        public double A = 3.5;

        #endregion

        #region constructors

        public Hypocycloid_B() : base()
        {

        }

        public Hypocycloid_B(double t) : base()
        {
            this.T = t;
        }

        public Hypocycloid_B(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;
            double u = (A - 1);

            p.X = u * Math.Cos(s) + Math.Cos(u * s);
            p.Y = u * Math.Sin(s) - Math.Sin(u * s);

        }

        #endregion

    }
}
