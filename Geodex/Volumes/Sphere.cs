using System;

namespace Geodex.Volumes
{
    public class Sphere : Field
    {
        public double A = 2.0;

        public Sphere() : base()
        {

        }

        public Sphere(double a) : base()
        {
            this.A = a;
        }

        public Sphere(UV uv, double a) : base()
        {
            this.A = a;
            this.U = uv.U;
            this.V = uv.V;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = A * Math.Cos(i) * Math.Sin(j);
            p.Y = A * Math.Sin(i) * Math.Sin(j);
            p.Z = A * Math.Cos(j);
        }
    }
}