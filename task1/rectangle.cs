using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Rectangle:Shape
    {
        protected int _height;
        protected int _width;
       public Rectangle(int _height,int _width) {

            this._height = _height;
            this._width = _width;
        }
        public override void CalculateArea()
        {
            Console.WriteLine("the area of a rectangle is {0}", _height * _width);


        }
        public override void CalculatePerimeter()
        {
            Console.WriteLine("the perimeter of a rectangle is {0}", (2 * _width * _height));
        }
        public void rectanglee()
        {
            Console.WriteLine();
        }



    }
}
