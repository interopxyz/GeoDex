using System;

namespace Geodex.Curves.Fixed
{
    public class Kappa : Curve
    {

        #region members

        #endregion

        #region constructors

        public Kappa() : base()
        {

        }

        public Kappa(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = Math.Sin(s);

            p.X = i;
            p.Y = i * Math.Tan(s);

        }

        #endregion

    }
}
