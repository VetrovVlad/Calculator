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
    class Linear_Equation
    {
        public string a { get; set; }

        public string x { get; set; }

        public string b { get; set; }

        public Linear_Equation() : this(0,0) { }

        public Linear_Equation(double a, double b)
        {
            this.NewEquation(a, b);
        }

        public string Root() { return x; }

        public string NewEquation(double a, double b)
        {
            this.a = Convert.ToString(a);
            this.b = Convert.ToString(b);

            if (a != 0)
                this.x = Convert.ToString(-b / a);
            else if (a == 0)
                this.x = "Коренів не має!";
            else if (a == 0 && b == 0)
                this.x = "Безліч коренів!";
        }
    }
}
