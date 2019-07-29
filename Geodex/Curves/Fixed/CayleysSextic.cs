using System;

namespace Geodex.Curves.Fixed
{
    public class CayleysSextic : Curve
    {

        #region members

        #endregion

        #region constructors

        public CayleysSextic() : base()
        {

        }

        public CayleysSextic(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = Math.Pow(Math.Cos(s / 3), 3);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
