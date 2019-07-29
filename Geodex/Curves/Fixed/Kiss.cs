using System;

namespace Geodex.Curves.Fixed
{
    public class Kiss: Curve
    {

        #region members

        #endregion

        #region constructors

        public Kiss() : base()
        {

        }

        public Kiss(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;
            
            p.X = Math.Cos(s);
            p.Y = Math.Pow(Math.Sin(s), 3);

        }

        #endregion

    }
}
