using System;

namespace Geodex.Volumes
{
    public class Torus : Field
    {
        public double A = 2.0;
        public double B = 1.0;

        public Torus() : base()
        {

        }

        public Torus(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Torus(UV uv, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.U = uv.U;
            this.V = uv.V;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = (A + B * Math.Cos(i)) * Math.Cos(j);
            p.Y = (A + B * Math.Cos(i)) * Math.Sin(j);
            p.Z = B * Math.Sin(i);
        }
    }
}