using System;

namespace Geodex.Curves.Continous
{
    public class Serpentine : Curve
    {
        double A = 1;
        double B = 1;

        public Serpentine() : base()
        {

        }

        public Serpentine(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Serpentine(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {

            p.X = t;
            p.Y = (A * B * t) / (Math.Pow(t, 2) + Math.Pow(A, 2));
        }
    }
}
