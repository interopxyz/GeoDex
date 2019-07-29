using System;

namespace Geodex.Curves.Fixed
{
    public class Trifolium : Curve
    {

        #region members

        #endregion

        #region constructors

        public Trifolium() : base()
        {

        }

        public Trifolium(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = Math.Cos(s) * (4 * Math.Pow(Math.Sin(s), 2) - 1);

            p.X = i*Math.Cos(s);
            p.Y = i*Math.Sin(s);

        }

        #endregion

    }
}
