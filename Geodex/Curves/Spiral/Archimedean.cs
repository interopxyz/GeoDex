using System;

namespace Geodex.Curves.Spiral
{
    public class Archimedean : Curve
    {

        #region members

        public double A = 1.0;
        public double B = 1.0;

        #endregion

        #region constructors

        public Archimedean() : base()
        {

        }

        public Archimedean(double t) : base()
        {
            this.T = t;
        }

        public Archimedean(double t, double a, double b) : base()
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

            double u = A+B*s;

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);

        }

        #endregion

    }
}
