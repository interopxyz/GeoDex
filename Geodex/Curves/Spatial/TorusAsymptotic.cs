using System;

namespace Geodex.Curves.Spatial
{
    public class TorusAsymptotic : Curve
    {

        #region members

        public double A = 1.0;
        public double B = 2.0;

        #endregion

        #region constructors

        public TorusAsymptotic() : base()
        {

        }

        public TorusAsymptotic(double t) : base()
        {
            this.T = t;
        }

        public TorusAsymptotic(double t, double a, double b) : base()
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

            p.X = (A + B * Math.Cos(s)) * Math.Cos(s);
            p.Y = (A + B * Math.Cos(s)) * Math.Sin(s);
            p.Z = B * Math.Sin(s);

        }

        #endregion

    }
}
