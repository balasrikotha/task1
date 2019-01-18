using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
   class program
    {
            static void Main(string[] args)
            {
             
            Shape s = new Square(55);
            s.CalculateArea();
            s.CalculatePerimeter();
            Square ss = new Square(55);
            ss.squareee();
            Shape r = new Rectangle(3,4);
            r.CalculatePerimeter();
            r.CalculateArea();
            Rectangle rr = new Rectangle(3, 4);
            rr.rectanglee();
            Shape c = new Circle(5);
            c.CalculateArea();
            c.CalculatePerimeter();
            Circle cc = new Circle(5);
            cc.circlee();




            }
        }
    }
