using System;

namespace Geodex.Curves.Open
{
    public class Logarithmic: Curve
    {

        #region members
        
        #endregion

        #region constructors

        public Logarithmic() : base()
        {

        }

        public Logarithmic(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = t;
            p.Y = Math.Pow(2,t);

        }

        #endregion

    }
}
