using System;

namespace Geodex.Curves.Spatial
{
    public class TorusKnot : Curve
    {

        #region members
        
        public double A = 2.0;
        public double B = 5.0;
        public double C = 3.0;
        public double D = 1.0;

        #endregion

        #region constructors

        public TorusKnot() : base()
        {

        }

        public TorusKnot(double t) : base()
        {
            this.T = t;
        }

        public TorusKnot(double t, double a, double b, double c, double d) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = D * Math.Cos(B * s) + C;

            p.X = i * Math.Cos(A * s);
            p.Y = i * Math.Sin(A * s);
            p.Z = D * Math.Sin(B * s);

        }

        #endregion

    }
}
