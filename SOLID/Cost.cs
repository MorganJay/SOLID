using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Costs
    {
        public double TotalArea(HouseParts[] parts)
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