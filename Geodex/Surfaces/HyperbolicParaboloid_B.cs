using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geodex.Surfaces
{
    public class HyperbolicParaboloid_B : Field
    {
        public double A = 1.0;
        public double B = 1.0;
        public double C = 1.0;

        public HyperbolicParaboloid_B() : base()
        {

        }

        public HyperbolicParaboloid_B(double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public HyperbolicParaboloid_B(UV uv, double a, double b, double c) : base()
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {

            p.X = A * U;
            p.Y = B*V;
            p.Z = C*(Math.Pow(U,2)-Math.Pow(V,2));

        }
    }
}