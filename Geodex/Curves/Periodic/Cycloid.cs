using System;

namespace Geodex.Curves.Periodic
{
    public class Cycloid : Curve
    {

        #region members

        #endregion

        #region constructors

        public Cycloid() : base()
        {

        }

        public Cycloid(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = s - Math.Sin(s);
            p.Y = 1 - Math.Cos(s);

        }

        #endregion

    }
}
