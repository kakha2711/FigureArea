using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Rectangle : Figura
    {
        private double _length;
        private double _width;

        public double Length
        {
            get
            {
                if (_length <= 0)
                {
                    throw new Exception("The length cannot be a zero or a negative number or nulable!");
                }

                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("The length cannot be a zero or a negative number or nulable!");
                }
                _length = value;
            }
        }

        public double Width
        {
            get
            {
                if (_width <= 0)
                {
                    throw new Exception("The length cannot be a zero or a negative number or nulable!");
                }

                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("The length cannot be a zero or a negative number or nulable!");
                }
                _width = value;
            }
        }

        public override double GetArea()
        {
            return _length * _width;
        }
    }
}
