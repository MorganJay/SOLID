using SOLID.Interfaces;

namespace SOLID
{
    public class Fancyline : INonAreaObject, IOtherFactors
    {
        public double Length { get; set; }

        public double Circumference()
        {
            return 2;
        }

        public double LengthForArea()
        {
            return 0;
        }

        public double Perimeter()
        {
            return 4;
        }
    }
}