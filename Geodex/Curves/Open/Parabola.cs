using System;

namespace Geodex.Curves.Open
{
    public class Parabola : Curve
    {
        double Focus = 1;

        public Parabola() : base()
        {

        }

        public Parabola(double focus) : base()
        {
            this.Focus = focus;
        }

        public Parabola(double t, double focus) : base()
        {
            this.Focus = focus;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
            
            p.X = t;
            p.Y = Math.Pow(t,2) / (4 * Focus);
        }
    }
}
