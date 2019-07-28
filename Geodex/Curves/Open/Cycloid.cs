using System;

namespace Geodex.Curves.Open
{
    public class Cycloid : Curve
    {
        public Cycloid() : base()
        {

        }
        public Cycloid(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = s - Math.Sin(s);
            p.Y = 1 - Math.Cos(s);
        }
    }
}
