using System;

namespace Geodex.Curves.Open
{
    public class Frequency : Curve
    {

        #region members
        
        #endregion

        #region constructors

        public Frequency() : base()
        {

        }

        public Frequency(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            p.X = t;
            p.Y = Math.Sqrt((2 * Math.PI) * Math.Exp(-Math.Pow(t, 2) / 2));

        }

        #endregion

    }
}

