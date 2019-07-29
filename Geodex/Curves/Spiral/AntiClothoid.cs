using System;

namespace Geodex.Curves.Spiral
{
    public class AntiClothoid : Curve
    {

        #region members

        #endregion

        #region constructors

        public AntiClothoid() : base()
        {

        }

        public AntiClothoid(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = Math.Cos(s) + s * Math.Sin(s);
            p.Y = Math.Sin(s) - s * Math.Cos(s);

        }

        #endregion

    }
}