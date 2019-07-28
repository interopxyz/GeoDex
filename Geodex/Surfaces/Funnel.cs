using System;

namespace Geodex.Surfaces
{
    public class Funnel : Field
    {
        public double A = 0.2;

        public Funnel() : base()
        {

        }

        public Funnel(double a) : base()
        {
            this.A = a;
        }

        public Funnel(UV uv, double a) : base()
        {
            this.A = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V * Math.PI;

            p.X = i * Math.Cos(j);
            p.Y = i * Math.Sin(j);
            p.Z = Math.Log(i);
        }
    }
}