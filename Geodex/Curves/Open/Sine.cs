using System;

namespace Geodex.Curves.Open
{
    public class Sine : Curve
    {
        public Sine() : base()
        {

        }
        public Sine(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            p = new Point(t, Math.Sin(t * Math.PI));
        }
    }
}
