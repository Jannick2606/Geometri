using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square
    {
        private double side;
        public double Side
        {
            get
            {
                return this.side;
            }
            set
            {
                this.side = value;
            }
        }

        public Square(double a)
        {
            this.side = a;
        }
        public double Perimeter()
        {  
            return side *4;
        }
        public double Area()
        {
            return side * side;
        }
    }
}
