using System;

namespace Geodex.Curves.Spiral
{
    public class Logarithmic : Curve
    {

        #region members

        public double A = 0.25;

        #endregion

        #region constructors

        public Logarithmic() : base()
        {

        }

        public Logarithmic(double t) : base()
        {
            this.T = t;
        }

        public Logarithmic(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double u = Math.Pow(Math.E, (A * s));

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);

        }

        #endregion

    }
}