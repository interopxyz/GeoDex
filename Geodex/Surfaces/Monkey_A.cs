using System;

namespace Geodex.Surfaces
{
    public class Monkey : Field
    {
        public double Depth = 1.0;

        public Monkey() : base()
        {

        }
        public Monkey(double depth) : base()
        {
            Depth = depth;
        }

        public Monkey(UV uv, double depth) : base()
        {
            Depth = depth;
            this.Parameter = uv;
        }

        protected override void Evaluate()
        {
            p.X = Parameter.U;
            p.Y = Parameter.V;
            p.Z = Depth * (Math.Pow(Parameter.U, 3) - 3 * Parameter.U * Math.Pow(Parameter.V, 2));
        }
    }
}
