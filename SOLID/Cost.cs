using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Interfaces;

namespace SOLID
{
    public static class Costs
    {
        public static double TotalArea(INonAreaObject[] parts)
        {
            double answer = 0;
            foreach (var part in parts)
            {
                answer += part.Area();
                part.LengthForArea();
            }

            return answer;
        }
    }
}