using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    public class AreaCalculator { 
        public double TotalArea(Rectangle[] arrRectangles)
        {
            double area;
            foreach (var objRectangle in arrRectangles)
            {
                area += objRectangle.Height * objRectangle.Width;
            }
            return area;
        }
    }
}
