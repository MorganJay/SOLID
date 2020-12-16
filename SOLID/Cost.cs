using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public static class Costs
    {
        public static double TotalArea(HouseParts[] parts)
        {
            double answer = 0;
            foreach (var part in parts)
            {
                answer += part.Area();
            }

            return answer;
        }
    }
}