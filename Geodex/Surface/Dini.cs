using System;

namespace Geodex.Surface
{
    public class Dini : Field
    {
        public double A = 0.2;

        public Dini() : base()
        {

        }

        public Dini(double a) : base()
        {
            this.A = a;
        }

        public Dini(UV uv, double a) : base()
        {
            this.A = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            double i = U * Math.PI;
            double j = V;


            p.X = Math.Cos(i) * Math.Sin(j);
            p.Y = Math.Sin(i) * Math.Sin(j);
            p.Z = (Math.Cos(j) + Math.Log(Math.Tan(j / 2))) + A * i;
        }
    }
}