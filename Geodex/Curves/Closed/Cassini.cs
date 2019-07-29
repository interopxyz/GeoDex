using System;

namespace Geodex.Curves.Closed
{
    public class Cassini : Curve
    {

        #region members

        public double A = 1.125;

        #endregion

        #region constructors

        public Cassini() : base()
        {

        }

        public Cassini(double t) : base()
        {
            this.T = t;
        }

        public Cassini(double t, double a) : base()
        {
            this.A = a;

            this.T = t;
        }

        #endregion

        #region methods

        protected override void Evaluate()
        {

            double s = t * Math.PI;

            double i = Math.Sqrt(Math.Cos(s * 2) + Math.Sqrt(Math.Pow((A), 4) - Math.Pow(Math.Sin(s * 2), 2)));
        
            p.X = i*Math.Cos(s);
            p.Y = i*Math.Sin(s);

        }

        #endregion

    }
}
