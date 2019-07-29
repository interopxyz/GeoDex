using System;

namespace Geodex.Curves.Spatial
{
    public class Basin : Curve
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;
        public double C = 5.0;
        public double D = 4.0;

        #endregion

        #region constructors

        public Basin() : base()
        {

        }

        public Basin(double t) : base()
        {
            this.T = t;
        }

        public Basin(double t, double a, double b, double c, double d) : base()
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

            double s = t * Math.PI * D;

            p.X = A * Math.Cos(s) * Math.Cos(C / D * s);
            p.Y = A * Math.Sin(s) * Math.Cos(C / D * s);
            p.Z = B * Math.Pow(Math.Cos(C / D * s), 2);

        }

        #endregion

    }
}
