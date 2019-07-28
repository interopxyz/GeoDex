using System;

namespace Geodex.Curves.Closed
{
    public class SuperEllipse : Curve
    {
        public double Width = 1;
        public double Height = 2;
        public double Pinch = 1;
        public SuperEllipse() : base()
        {

        }

        public SuperEllipse(double width, double height, double pinch) : base()
        {
            this.Width = width;
            this.Height = height;
            this.Pinch = pinch;
        }

        public SuperEllipse(double t, double width, double height, double pinch) : base()
        {
            this.Width = width;
            this.Height = height;
            this.Pinch = pinch;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            p.X = Math.Pow(Math.Abs(Math.Cos(s)), (2 / Pinch)) * Width * Math.Sign(Math.Cos(s));
            p.Y = Math.Pow(Math.Abs(Math.Sin(s)), (2 / Pinch)) * Height * Math.Sign(Math.Sin(s));
        }
    }
}
