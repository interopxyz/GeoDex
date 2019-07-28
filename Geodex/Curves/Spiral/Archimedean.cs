using System;

namespace Geodex.Curves.Spiral
{
    public class Archimedean : Curve
    {
        public double Shift = 0;
        public double Spacing = 1;
        public Archimedean() : base()
        {

        }

        public Archimedean(double shift, double spacing) : base()
        {
            this.Shift = shift;
            this.Spacing = spacing;
        }

        public Archimedean(double t, double shift, double spacing) : base()
        {
            this.Shift = shift;
            this.Spacing = spacing;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double u = Shift+Spacing*s;

            p.X = u * Math.Cos(s);
            p.Y = u * Math.Sin(s);
        }
    }
}
