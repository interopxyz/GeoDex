using System;

namespace Geodex.Curves.Fixed
{
    public class Tricuspoid : Curve
    {

        #region members

        #endregion

        #region constructors

        public Tricuspoid() : base()
        {

        }

        public Tricuspoid(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = 2 * Math.Cos(s) + Math.Cos(2 * s);
            p.Y = 2 * Math.Sin(s) - Math.Sin(2 * s);

        }

        #endregion

    }
}
