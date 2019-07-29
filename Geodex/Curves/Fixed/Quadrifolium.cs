using System;

namespace Geodex.Curves.Fixed
{
    public class Quadrifolium: Curve
    {

        #region members

        #endregion

        #region constructors

        public Quadrifolium() : base()
        {

        }

        public Quadrifolium(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = Math.Sin(2 * s);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
