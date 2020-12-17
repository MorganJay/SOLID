using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Interfaces;

namespace SOLID
{
    public abstract class HouseParts : IAreaObject, INonAreaObject
    {
        public virtual double Area()
        {
            return 0;
        }

        public double LengthForArea()
        {
            return 0;
        }
    }
}