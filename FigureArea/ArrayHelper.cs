using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public abstract class Comparable
    {
        public abstract int CompareTo(object obj);
    }

    static class ArrayHelper
    {
        //TODO: დაალაგეთ რიცხვები ზრდადობის მიხედვით.
        public static void Sort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        //TODO: დაალაგეთ ფიგურები ზრდადობით ფართობის მიხედვით.
        public static void Sort(Figura[] array)
        {
            Figura temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].GetArea() > array[j + 1].GetArea())
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        //TODO: დაალაგეთ უცნობი ობიექტები ზრდადობით.
        public static void Sort(object[] array)
        {
            object temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if ((array[j] as Comparable).CompareTo(array[j + 1]) == 1)
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
