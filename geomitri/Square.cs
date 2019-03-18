using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geomitri
{
    class Square
    {
        private double side;

            public Square(double side)
        {
            this.side = side;
        }

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }

        public Square() // constructor we can use for logic 
        {
            
        }

        public double Omkreds() //finds omkreds
        {
           return side * 4;
        }

        public double Areal() //finds areal
        {
            return Math.Pow(side, 2);
        }
    }
}
