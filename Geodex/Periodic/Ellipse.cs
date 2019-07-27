using System;

namespace Geodex.Curves.Periodic
{
    public class Ellipse : Curve
    {
        public double Width = 1;
        public double Height = 2;
        public Ellipse() : base()
        {

        }

        public Ellipse(double width, double height) : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public Ellipse(double t, double width, double height) : base()
        {
            this.Width = width;
            this.Height = height;
            this.T = t;
        }

        protected override void Evaluate()
        {
            p.X = Width * Math.Sin(t * Math.PI);
            p.Y = Height * Math.Cos(t * Math.PI);
        }
    }
}
