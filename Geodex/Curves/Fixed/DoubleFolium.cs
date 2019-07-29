using System;

namespace Geodex.Curves.Fixed
{
    public class DoubleFolium : Curve
    {

        #region members

        #endregion

        #region constructors

        public DoubleFolium() : base()
        {

        }

        public DoubleFolium(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = 4 * Math.Cos(s) * Math.Pow(Math.Sin(s), 2);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
