using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle2       // Niklas Sjödin NET23
{
    internal class Triangle
    {
        double _baseLenght;
        double _height;
        double _hypotenusa;

        public Triangle(double baseLenght, double height, double hypotenusa)       // Constructor för basen och höjden
        {
            _baseLenght = baseLenght;
            _height = height;
            _hypotenusa = hypotenusa;

        }

        public double GetTArea()        // Metoden för att räkna ur arean
        {
            return _baseLenght * _height / 2;
        }

        public double GetTCircumference()       // Metoden för att räkna ur omkretsen
        {
            return _baseLenght + _height + _hypotenusa;
        }

        public double GetTVolume()      // Metoden för att räkna ut volymen
        {
            return _baseLenght * _hypotenusa * _height;
        }
    }
}
