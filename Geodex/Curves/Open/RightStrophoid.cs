using System;

namespace Geodex.Curves.Open
{
    public class RightStrophoid : Curve
    {

        #region members

        public double A = 1.0;

        #endregion

        #region constructors

        public RightStrophoid() : base()
        {

        }

        public RightStrophoid(double t) : base()
        {
            this.T = t;
        }

        public RightStrophoid(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t*Math.PI;

            double i = Math.Cos(2 * s) / Math.Cos(s);
            
            p.X = (s * ((Math.Pow(s, 2) - Math.Pow(A, 2))) / ((Math.Pow(s, 2) + Math.Pow(A, 2))));
            p.Y = ((Math.Pow(A, 2) - Math.Pow(s, 2)) / ((Math.Pow(s, 2) + Math.Pow(A, 2)))) * A;

        }

        #endregion

    }
}
