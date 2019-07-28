using System;

namespace Geodex.Surfaces
{
    public class Conocuneus : Field
    {
        public double A = 1.0;
        public double B = 1.0;
        public double C = 0.25;
        public double D = 0.5;

        public Conocuneus() : base()
        {

        }

        public Conocuneus(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Conocuneus(UV uv, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            double k = A - C * Math.Cos(i) * Math.Cos(j);

            p.X = (D * (C - A * Math.Cos(i) * Math.Cos(j)) + Math.Pow(B, 2) * Math.Cos(i)) / k;
            p.Y = (B * Math.Sin(i) * (A - D * Math.Cos(j))) / k;
            p.Z = (B * Math.Sin(j) * (C * Math.Cos(i) - D)) / k;

        }
    }
}