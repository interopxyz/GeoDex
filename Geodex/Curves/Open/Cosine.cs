using System;

namespace Geodex.Curves.Open
{
    public class Cosine : Curve
    {
        public Cosine() : base()
        {

        }
        public Cosine(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            p.X = t;
            p.Y =  Math.Cos(t * Math.PI);
        }
    }
}
