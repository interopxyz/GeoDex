using System;

namespace Geodex.Curves.Closed
{
    public class Quadrifolium: Curve
    {
        public Quadrifolium() : base()
        {

        }

        public Quadrifolium(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = Math.Sin(2 * s);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);
        }
    }
}
