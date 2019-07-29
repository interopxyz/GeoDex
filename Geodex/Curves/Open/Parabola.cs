using System;

namespace Geodex.Curves.Open
{
    public class Parabola : Curve
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public Parabola() : base()
        {

        }

        public Parabola(double t) : base()
        {
            this.T = t;
        }

        public Parabola(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;
            
            p.X = t;
            p.Y = Math.Pow(t,2) / (4 * A);

        }

        #endregion

    }
}
