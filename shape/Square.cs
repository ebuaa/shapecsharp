using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class Square : Shape
    {
        public double Height {  get; set; }

        public override double Area()
        {
            return Height * Height;
        }
    }
}
