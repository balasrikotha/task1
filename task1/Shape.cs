using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    abstract class Shape
    {
        protected int _area;
        protected string _color;
        protected int _perimeter;
        public Shape() { }

        public Shape(int _area, string _color, int _perimeter)
        {
            this._area = _area;
            this._color = _color;
            this._perimeter = _perimeter;

        }
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();

    }
}
