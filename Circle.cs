using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle2       // Niklas Sjödin NET23
{
    internal class Circle
    {
        int _radius;


        public Circle(int radius)       // Constructor för radien
        {
            _radius = radius;
        }

        public double GetArea()     // Metod för att hämta uträkningen för arean
        {
            return _radius * _radius * Math.PI;
        }

        public double GetCircumference()        // Metod för att hämta uträkningen för omkretsen
        {
            return 2 * Math.PI * _radius;
        }

        public double GetVolume()       // Metod för att hämta uträkningen för volymen
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
        }

    }
}
