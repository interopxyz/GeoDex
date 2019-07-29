using System;

namespace Geodex.Curves.Open
{
    public class SluzeCubic : Curve
    {

        #region members

        public double A = 0.5;
        public double B = 2.0;

        #endregion

        #region constructors

        public SluzeCubic() : base()
        {

        }

        public SluzeCubic(double t) : base()
        {
            this.T = t;
        }

        public SluzeCubic(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = A / Math.Cos(s) + (Math.Pow(B, 2) / A) * Math.Cos(s);

            p.X = i * Math.Sin(s);
            p.Y = i * Math.Cos(s);

        }

        #endregion

    }
}
