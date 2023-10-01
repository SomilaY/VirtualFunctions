using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunctions
{
    public class Rectangle : Shape
    {
        public Rectangle(double x, double y) : base(x, y)
        {
            //this.Length = x;
            //this.Width = y;
        } 

        public override double Area =>
            this.Length * this.Width;
        

        public override string PrintShape() =>
             "This is a Rectangle";
        
    }
}
