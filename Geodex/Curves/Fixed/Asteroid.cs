using System;

namespace Geodex.Curves.Fixed
{
    public class Asteroid : Curve
    {

        #region members

        #endregion

        #region constructors

        public Asteroid() : base()
        {

        }

        public Asteroid(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            p.X = Math.Pow(Math.Cos(s),3);
            p.Y = Math.Pow(Math.Sin(s),3);

        }

        #endregion

    }
}
