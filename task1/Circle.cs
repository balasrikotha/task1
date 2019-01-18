using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Circle : Shape
    {
        protected int _radius;
        public Circle(int _radius)
        {
            this._radius = _radius;

        }
        public override void CalculateArea()
        {
            Console.WriteLine("the area of a circle is {0}", (3.14*_radius*_radius));
        }
        public override void CalculatePerimeter()
        {
            Console.WriteLine("the perimeter of a circle is {0}", (3.14 *4 * _radius));
        }

        public void circlee()
        {
            Console.WriteLine("---");
        }
    }
}
