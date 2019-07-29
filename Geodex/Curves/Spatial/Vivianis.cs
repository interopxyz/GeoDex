using System;

namespace Geodex.Curves.Spatial
{
    public class Vivianis : Curve
    {

        #region members

        #endregion

        #region constructors

        public Vivianis() : base()
        {

        }

        public Vivianis(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = (1 + Math.Cos(s));
            p.Y = Math.Sin(s);
            p.Z = 2 * Math.Sin(s / 2);

        }

        #endregion

    }
}
