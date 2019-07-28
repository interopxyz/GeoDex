using System;

namespace Geodex.Curves.Open
{
    public class Butterfly : Curve
    {

        public Butterfly() : base()
        {

        }

        public Butterfly(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t*Math.PI;
            double u = (Math.Pow(Math.E, Math.Cos(s)) - 2.0 * Math.Cos(4.0 * s) - Math.Pow(Math.Sin(s / 12.0), 5.0));

            p.X = Math.Sin(s) * u;
            p.Y = Math.Cos(s) * u;
        }
    }
}
