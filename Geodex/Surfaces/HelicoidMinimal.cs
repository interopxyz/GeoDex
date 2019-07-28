using System;

namespace Geodex.Surfaces
{
    public class HelicoidMinimal : Field
    {
        public double A = 1.0;

        public HelicoidMinimal() : base()
        {

        }

        public HelicoidMinimal(double a) : base()
        {
            this.A = a;
        }

        public HelicoidMinimal(UV uv, double a) : base()
        {
            this.A = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;
            double k = A * Math.PI;

            p.X = Math.Pow(Math.E, i) * Math.Cos(j - k) / 2 + Math.Pow(Math.E, -i) * Math.Cos(j + k) / 2;
            p.Y = Math.Pow(Math.E, i) * Math.Sin(j - k) / 2 + Math.Pow(Math.E, -i) * Math.Sin(j + k) / 2;
            p.Z = Math.Cos(k) * i + Math.Sin(k) * j;
        }
    }
}
