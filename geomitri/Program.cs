using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geomitri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square foursites = new Square(200); //making new object square

            Square foursitestwo = new Square(300);

            Square empty = new Square();

            empty.Side = 20;
            Console.WriteLine(foursites.Omkreds());

            Console.WriteLine(foursitestwo.Omkreds());

            Console.WriteLine(foursites.Areal());

            Console.WriteLine(empty.Areal());
        }
    }
}
