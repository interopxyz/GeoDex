using System;

namespace Geodex.Surfaces
{
    public class Guimards : Field
    {
        public double A = 1.0;
        public double B = 1.0;
        public double C = 1.0;

        public Guimards() : base()
        {

        }

        public Guimards(double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public Guimards(UV uv, double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = ((1 - i) * A + i * B) * Math.Cos(j);
            p.Y = B * i * Math.Sin(j);
            p.Z = C * i * Math.Pow(Math.Sin(j), 2);

        }
    }
}