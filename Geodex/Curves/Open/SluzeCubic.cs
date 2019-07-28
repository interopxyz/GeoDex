using System;

namespace Geodex.Curves.Open
{
    public class SluzeCubic : Curve
    {
        public double A = 1.0;
        public double B = 1.0;

        public SluzeCubic() : base()
        {

        }
        public SluzeCubic(double a, double b) : base()
        {
            A = a;
            B = b;
        }

        public SluzeCubic(double t, double a, double b) : base()
        {
            A = a;
            B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = A / Math.Cos(s) + (Math.Pow(B, 2) / A) * Math.Cos(s);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}
