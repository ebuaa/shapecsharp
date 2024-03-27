using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape 
{
    public class Triangle : Shape
    {
        public double Height1 { get; set; }
        public double Height2 { get; set; }
        public double Height3 { get; set; }

        public override double Area()
        {
            return (Height1 + Height2 + Height3) / 2;

        }
    }
}
