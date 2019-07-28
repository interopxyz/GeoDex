using System;

namespace Geodex.Curves.Spiral
{
    public class Cochleoid : Curve
    {
        public Cochleoid() : base()
        {

        }

        public Cochleoid(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = (Math.Sin(s) * Math.Cos(s)) / s;
            p.Y = (Math.Pow(Math.Sin(s), 2)) / s;
        }
    }
}
