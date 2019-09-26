using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Calculator.Droid
{
    class Square_Equation
    {
        public string a { get; set; }

        public string b { get; set; }

        public string c { get; set; }

        public string x1 { get; set; }

        public string x2 { get; set; }

        public Square_Equation() : this(0,0,0) { }

        public Square_Equation(double a, double b, double c)
        {
            this.a = Convert.ToString(a);
            this.b = Convert.ToString(b);
            this.c = Convert.ToString(c);

            double Discriminant = (b * b) - (4 * a * c);

            if (Discriminant < 0)
            {
                x1 = "Корені комплексні!";
                x2 = "Корені комплексні!";
            }
            else
            {
                x1 = Convert.ToString((-b + Math.Sqrt(Discriminant)) / (2 * a));
                x2 = Convert.ToString((-b - Math.Sqrt(Discriminant)) / (2 * a));
            }

        }

        public string Root1() { return x1; }

        public string Root2() { return x2; }
    }
}