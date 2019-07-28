using System;

namespace Geodex.Curves.Fixed
{
    public class HumbertCubic : Curve
    {
        public double A = 1;

        public HumbertCubic() : base()
        {

        }

        public HumbertCubic(double a) : base()
        {
            this.A = a;
        }

        public HumbertCubic(double t, double a) : base()
        {
            this.A = a;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = A / Math.Pow(Math.Cos(3.0 * s), 1.0 / 3.0);


            p.X = i * Math.Sin(s);
            p.Y = i * Math.Cos(s);
        }
    }
}
