using System;

namespace Geodex.Surfaces
{
    public class Shell : Field
    {
        public double A = 1.0;
        public double B = 1.0;
        public double C = 1.0;
        public double D = 1.0;
        public double E = 1.0;

        public Shell() : base()
        {

        }
        public Shell(double a, double b, double c, double d, double e) : base()
        {
            A = a;
            B = a;
            C = a;
            D = a;
            E = a;
        }

        public Shell(UV uv, double a, double b, double c, double d, double e) : base()
        {
            A = a;
            B = a;
            C = a;
            D = a;
            E = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;
            
            double k = (A + B * Math.Cos(j)) * Math.Pow(E, C * i);

            p.X = k * Math.Cos(i);
            p.Y = k * Math.Sin(i);
            p.Z = (D * A + B * Math.Sin(j)) * Math.Pow(E, C * i);
        }
    }
}
