using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geodex.Surfaces
{
    public class HyperbolicParaboloid_A : Field
    {
        public double A = 1.0;
        public double B = 1.0;
        public double C = 1.0;

        public HyperbolicParaboloid_A() : base()
        {

        }

        public HyperbolicParaboloid_A(double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public HyperbolicParaboloid_A(UV uv, double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            p.X = (A / 2) * (U + V);
            p.Y = (B / 2) * (U - V);
            p.Z = C * U * V;

        }
    }
}