using System;

namespace Geodex.Curves.Spiral
{
    public class Fermat : Curve
    {

        #region members

        public double A = 1;

        #endregion

        #region constructors

        public Fermat() : base()
        {

        }

        public Fermat(double t) : base()
        {
            this.T = t;
        }

        public Fermat(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = A*Math.Pow(s, 0.5);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
