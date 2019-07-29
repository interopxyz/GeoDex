using System;

namespace Geodex.Curves.Fixed
{
    public class Bicorn : Curve
    {

        #region members

        #endregion

        #region constructors

        public Bicorn() : base()
        {

        }

        public Bicorn(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = Math.Sin(s);
            p.Y = (Math.Pow(Math.Cos(s), 2) * (2 + Math.Cos(s))) / (3 + Math.Pow(Math.Sin(s),2));

        }

        #endregion

    }
}
