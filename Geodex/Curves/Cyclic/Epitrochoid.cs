using System;

namespace Geodex.Curves.Cyclic
{
    public class Epitrochoid : Curve
    {

        #region members

        public double A = 5.0;
        public double B = 2.0;
        public double C = 4.0;

        #endregion

        #region constructors

        public Epitrochoid() : base()
        {

        }

        public Epitrochoid(double t) : base()
        {
            this.T = t;
        }

        public Epitrochoid(double t, double a, double b, double c) : base()
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
            double u = (A + B);
            double v = u/ B * s;

            p.X = u * Math.Cos(s) - C * Math.Cos(v);
            p.Y = u * Math.Sin(s) - C * Math.Sin(v);

        }

        #endregion

    }
}
