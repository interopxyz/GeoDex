using System;

namespace Geodex.Curves.Fixed
{
    public class MalteseCross:Curve
    {

        #region members

        #endregion

        #region constructors

        public MalteseCross() : base()
        {

        }

        public MalteseCross(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = s - Math.PI / 4;

            p.X = Math.Pow(Math.Cos(i), 3) - Math.Sin(i) / 2;
            p.Y = Math.Pow(Math.Sin(i), 3) - Math.Cos(i) / 2;

        }

        #endregion

    }
}
