using System;

namespace Geodex.Curves.Closed
{
    public class Biquartic : Curve
    {

        #region members

        public double A = 3.0;

        #endregion

        #region constructors

        public Biquartic() : base()
        {

        }

        public Biquartic(double t) : base()
        {
            this.T = t;
        }

        public Biquartic(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = Math.Sin(A * s) * Math.Cos(s);
            p.Y = Math.Pow(Math.Sin(A * s) * Math.Sin(s),2);

        }

        #endregion

    }
}
