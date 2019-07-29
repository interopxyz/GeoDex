using System;

namespace Geodex.Curves.Fixed
{
    public class Cardioid : Curve
    {

        #region members

        #endregion

        #region constructors

        public Cardioid() : base()
        {

        }

        public Cardioid(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = 1 + Math.Cos(s);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
