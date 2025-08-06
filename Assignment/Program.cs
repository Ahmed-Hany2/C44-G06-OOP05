using Assignment.Classes;
using Assignment.Interfaces;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICircle Circle1 = new Circle(5.5);
            IRectangle Rectangle1 = new Rectangle(4.5, 7);

            Circle1.DisplayShapeInfo();
            Rectangle1.DisplayShapeInfo();
        }
    }
}
