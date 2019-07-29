using System;

namespace Geodex.Curves.Spiral
{
    public class Cochleoid : Curve
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public Cochleoid() : base()
        {

        }

        public Cochleoid(double t) : base()
        {
            this.T = t;
        }

        public Cochleoid(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = (A * Math.Sin(s)) / s;

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s); ;

        }

        #endregion

    }
}
