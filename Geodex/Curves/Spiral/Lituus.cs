using System;

namespace Geodex.Curves.Spiral
{
    public class Lituus : Curve
    {

        #region members

        public double A = 1;

        #endregion

        #region constructors

        public Lituus() : base()
        {

        }

        public Lituus(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double u = Math.Sqrt(Math.Pow(A,2)/s);

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);

        }

        #endregion

    }
}
