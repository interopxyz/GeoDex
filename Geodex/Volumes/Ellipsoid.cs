using System;

namespace Geodex.Volumes
{
    public class Ellipsoid : Field
    {
        public double A = 2.0;
        public double B = 1.0;
        public double C = 0.5;

        public Ellipsoid() : base()
        {

        }

        public Ellipsoid(double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public Ellipsoid(UV uv, double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.U = uv.U;
            this.V = uv.V;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = A * Math.Cos(i) * Math.Sin(j);
            p.Y = B * Math.Sin(i) * Math.Sin(j);
            p.Z = C * Math.Cos(j);
                
        }
    }
}