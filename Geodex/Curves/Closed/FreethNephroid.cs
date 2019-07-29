using System;

namespace Geodex.Curves.Closed
{
    public class FreethNephroid : Curve
    {

        #region members

        public double A = 2.0;

        #endregion

        #region constructors

        public FreethNephroid() : base()
        {

        }

        public FreethNephroid(double t) : base()
        {
            this.T = t;
        }

        public FreethNephroid(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = (1 + A * Math.Sin(s / 2));

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}
