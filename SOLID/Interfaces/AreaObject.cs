using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    public interface IAreaObject
    {
        public double Area();
    }

    public interface IOtherFactors
    {
        double Perimeter();

        double Circumference();
    }
}