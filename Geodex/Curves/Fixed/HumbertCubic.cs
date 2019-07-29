using System;

namespace Geodex.Curves.Fixed
{
    public class HumbertCubic : Curve
    {

        #region members
        
        #endregion

        #region constructors

        public HumbertCubic() : base()
        {

        }

        public HumbertCubic(double t) : base()
        {
            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = 1 / Math.Pow(Math.Cos(3.0 * s), 1.0 / 3.0);


            p.X = i * Math.Sin(s);
            p.Y = i * Math.Cos(s);

        }

        #endregion

    }
}
