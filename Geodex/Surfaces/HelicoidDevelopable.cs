using System;

namespace Geodex.Surfaces
{
    public class HelicoidDevelopable : Field
    {
        public double A = 1.0;
        public double B = 1.0;

        public HelicoidDevelopable() : base()
        {

        }

        public HelicoidDevelopable(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public HelicoidDevelopable(UV uv, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;
            
            p.X = A * (Math.Cos(i) - j * Math.Sin(i));
            p.Y = A * (Math.Sin(i) + j * Math.Cos(i));
            p.Z = B * (i + j);
        }
    }
}
