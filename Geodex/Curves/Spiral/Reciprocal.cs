using System;

namespace Geodex.Curves.Spiral
{
    public class Reciprocal : Curve
    {
        public Reciprocal() : base()
        {

        }

        public Reciprocal(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = 1 / s;

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);
        }
    }
}
