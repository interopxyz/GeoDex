using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geodex.Curves.Open
{
    public class Logarithmic: Curve
    {
        public double A = 1;
        public double B = 2;

        public Logarithmic() : base()
        {

        }

        public Logarithmic(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
        }

        public Logarithmic(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            p.X = t;
            p.Y = A * Math.Log(t / B);
        }
    }
}
