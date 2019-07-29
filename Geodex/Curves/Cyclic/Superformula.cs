using System;

namespace Geodex.Curves.Cyclic
{
    public class Superformula : Curve
    {

        #region members
        
        public double A = 0.75;
        public double B = 5.0;
        public double C = 1.0;
        public double D = 4.0;
        public double E = 2.0;
        public double F = 6.0;

        #endregion

        #region constructors

        public Superformula() : base()
        {

        }

        public Superformula(double t) : base()
        {
            this.T = t;
        }

        public Superformula(double t, double a, double b, double c, double d, double e, double f ) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.E = e;
            this.F = f;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double u = Math.Pow(Math.Abs(1 / A * Math.Abs(Math.Cos(F * s / 4))), D) + Math.Pow(Math.Abs(1 / B + Math.Abs(Math.Sin(F * s / 4))), E);
            double v = Math.Pow(Math.Abs(u), (-1 / C));

            p.X = v * Math.Cos(s);
            p.Y = v * Math.Sin(s);

        }

        #endregion

    }
}
