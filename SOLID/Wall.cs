using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Wall : HouseParts
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public string Color { get; set; }

        public override double Area()
        {
            return Length * Breadth;
        }
    }
}