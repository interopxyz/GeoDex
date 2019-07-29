using System;

namespace Geodex.Curves.Closed
{
    public class Bifolium : Curve
    {

        #region members

        public double A = 0;
        public double B = 2.0;

        #endregion

        #region constructors

        public Bifolium() : base()
        {

        }

        public Bifolium(double t) : base()
        {
            this.T = t;
        }

        public Bifolium(double t, double a, double b) : base()
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

            double i = (A * Math.Cos(s) + B * Math.Sin(s)) * Math.Pow(Math.Cos(s), 2);
            
            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }

        #endregion

    }
}

