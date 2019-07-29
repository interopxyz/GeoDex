using System;

namespace Geodex.Curves.Fixed
{
    public class Lemniscate : Curve
    {

        #region members

        #endregion

        #region constructors

        public Lemniscate() : base()
        {

        }

        public Lemniscate(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double u = Math.Pow(Math.Sin(s), 2) + 1;

            p.X = (Math.Sqrt(2) * Math.Cos(s)) / u;
            p.Y = (Math.Sqrt(2) * Math.Cos(s) * Math.Sin(s)) / u;

        }

        #endregion

    }
}
