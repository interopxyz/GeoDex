using System;

namespace Geodex.Curves.Periodic
{
    public class Circle : Curve
    {
        public Circle() : base()
        {

        }
        public Circle(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = Math.Cos(s);
            p.Y = Math.Sin(s);
        }
    }
}
