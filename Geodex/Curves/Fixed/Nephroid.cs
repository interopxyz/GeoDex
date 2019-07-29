using System;

namespace Geodex.Curves.Fixed
{
    public class Nephroid : Curve
    {

        #region members

        #endregion

        #region constructors

        public Nephroid() : base()
        {

        }

        public Nephroid(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = 3*Math.Cos(s)-Math.Cos(3*s);
            p.Y = 3 * Math.Sin(s) - Math.Sin(3 * s);

        }

        #endregion

    }
}
