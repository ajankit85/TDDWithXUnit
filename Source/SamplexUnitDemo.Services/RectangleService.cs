using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplexUnitDemo.Services
{
    public class RectangleService
    {
        public double Area(double length, double width)
        {
            return length*width;
        }

        public double Perimeter(double length, double width)
        {
            return 2*(length + width);
        }
    }
}
