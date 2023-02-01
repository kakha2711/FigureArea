using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    internal class Triangle : Figura
    {
        private double _side;
        private double _height;

        public double Side
        {
            get
            {
                if (_side <= 0)
                {
                    throw new ArgumentOutOfRangeException("Tis value is incorect");
                }
                return _side;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Tis value is incorect");
                }
                _side = value;
            }
        }

        public double Height
        {
            get
            {
                if (_height <= 0)
                {
                    throw new ArgumentOutOfRangeException("Tis value is incorect");
                }

                return _height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Tis value is incorect");
                }
                _height = value;
            }
        }

        public override double GetArea()
        {
            return Side * Height / 2;
        }
    }
}
