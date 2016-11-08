namespace Geometry
{
    public class Triangle
    {
        private const double Half = 0.5;

        public double Area(double width, double height)
        {
            return width * height * Half;
        }
    }
}
