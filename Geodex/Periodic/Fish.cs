using System;

namespace Geodex.Curves.Periodic
{
    public class Fish : Curve
    {
        public Fish() : base()
        {

        }

        public Fish(double t) : base()
        {
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;
            
            p.X = Math.Cos(s) - ( Math.Pow(Math.Sin(s), 2)) / Math.Sqrt(2);
            p.Y =  Math.Cos(s) * Math.Sin(s);
        }
    }
}
