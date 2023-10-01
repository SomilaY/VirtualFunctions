using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunctions
{
    public class Square : Shape
    {
        public Square(double side) : base(side,0)
        {
           
        }

        public override double Area =>
           this.Length * this.Length;

        public override string PrintShape() =>
           "This is a Square";


    }

}
