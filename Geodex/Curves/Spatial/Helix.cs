using System;

namespace Geodex.Curves.Spatial
{
    public class Helix : Curve
    {

        #region members

        #endregion

        #region constructors

        public Helix() : base()
        {

        }

        public Helix(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = Math.Cos(s);
            p.Y = Math.Sin(s);
            p.Z = s;

        }

        #endregion

    }
}
