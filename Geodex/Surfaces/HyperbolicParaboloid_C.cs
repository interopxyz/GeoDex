using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geodex.Surfaces
{
    public class HyperbolicParaboloid_C : Field
    {
        public double A = 1.0;

        public HyperbolicParaboloid_C() : base()
        {

        }

        public HyperbolicParaboloid_C(double a) : base()
        {
            this.A = a;
        }

        public HyperbolicParaboloid_C(UV uv, double a) : base()
        {
            this.A = a;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            p.X = U * Math.Cos(V);
            p.Y = A * Math.Tan(V);
            p.Z = U * Math.Sin(V);
        }
    }
}