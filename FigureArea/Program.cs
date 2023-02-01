using System;

namespace FigureArea
{
    class Program
    {
        /* amocana
         * faunas proeqtshi creatureshi daamatet int-is tviseba weight.
         * gadaitanet im proeqtshi array helper classi da moaxdinet dzaglebis masivis sortireba mati conebis mixedvit.
         * daalagos conis zrdadobis mixedvit.
         * bunebrivia array helper classis cvlileba ar unda mogvicios.
         */
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = r.Next(100);
            }

            ArrayHelper.Sort(numbers);
            //Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();

            Square square1 = new Square(12);
            Square square2 = new Square(20);
            Rectangle rectangle = new Rectangle() { Width = 10, Length = 15 };

            square1.PrintNumber();
            square2.PrintNumber();

            //PrintArea(square1);
            //PrintArea(square2);
            //PrintArea(rectangle);

            //double sum = GetAreaSum(square1, square2, rectangle);
            //Console.WriteLine(sum);

            //Console.WriteLine(square1);
            //Console.WriteLine(rectangle);

            #region Kaxa
            //double side;

            //Console.Write("Write the side of the square: ");
            //side = Convert.ToDouble(Console.ReadLine());
            //Square square = new Square(side);
            //Console.WriteLine($" Square area is {square.GetArea()}");

            //Console.WriteLine();

            //Rectangle rectangle = new Rectangle();
            //Console.Write("Write the length of the rectangle: ");
            //rectangle.Length = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Write the whidth of the rectangle: ");
            //rectangle.Width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($" Square area is {rectangle.GetArea()}");

            //Console.WriteLine();

            //Triangle triangle = new Triangle();
            //Console.Write("Write the height of the triangle: ");
            //triangle.Height = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Write the side of the triangle: ");
            //triangle.Side = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($" Triangle area is {triangle.GetArea()}");

            //Console.WriteLine();

            //Circle circle = new Circle();
            //Console.Write("Write the radius of the circle: ");
            //circle.Radius = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($" Circle area is {circle.GetArea()}"); 
            #endregion
        }

        static void PrintArea(Figura figura)
        {
            if (figura is Square x)
                x.PrintNumber();

            if (figura is Square)
            {
                //(figura as Square).PrintNumber();
                //((Square)figura).PrintNumber();
                Square square = (Square)figura;
                square.PrintNumber();
            }

            Console.WriteLine($"Figure area is: {figura.GetArea()}");
        }

        static double GetAreaSum(params Figura[] figuras)
        {
            double sum = 0;
            for (int i = 0; i < figuras.Length; i++)
            {
                sum += figuras[i].GetArea();
            }
            return sum;
        }
    }
}
