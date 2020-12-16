using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class TriangleDecor : HouseParts
    {
        public double Height { get; set; }
        public double Base { get; set; }

        public override double Area()
        {
            return 0.5 * Height * Base;
        }
    }
}