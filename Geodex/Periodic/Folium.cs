using System;

namespace Geodex.Curves.Periodic
{
    public class Folium : Curve
    {
        double A = 0.25;
        double B = 1;
        public Folium() : base()
        {

        }

        public Folium(double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        public Folium(double t, double a, double b) : base()
        {
            this.A = a;
            this.B = b;
            this.T = t;
        }

        protected override void Evaluate()
        {
            double s = t * Math.PI;

            double i = -B*Math.Cos(s)+4*A*Math.Cos(s)*Math.Pow(Math.Sin(s),2);

            p.X = i * Math.Cos(s);
            p.Y = i * Math.Sin(s);

        }
    }
}
