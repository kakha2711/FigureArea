using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    internal class Square : Figura
    {
        public Square(double number)
        {
            if (number <= 0)
            {
                throw new Exception("The side of a square cannot be a zero or a negative number!");
            }

            Number = number;
        }

        public void PrintNumber()
        {
            Console.WriteLine($"Square Number is: {Number}");
        }

        public double Number { get; private set; }

        public override double GetArea()
        {
            return Math.Pow(Number, 2);
        }
    }
}
