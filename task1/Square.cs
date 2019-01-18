using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Square : Shape
    {
        protected int _side;
        public Square (int _side){
            this._side = _side;
          }
        public override void CalculateArea( )
        {
            Console.WriteLine("the area of a square is {0}",_side*_side);
        }
        public override void CalculatePerimeter()
        {
            Console.WriteLine("the perimeter of a square is {0}", 4 * _side);
        }
        public void squareee(){
            Console.WriteLine("---");

         }
    }
}
