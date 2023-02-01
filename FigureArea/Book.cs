using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Book : Comparable
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public override int CompareTo(object obj)
        {
            if (this.Price > (obj as Book).Price)
                return 1;
            else if (this.Price < (obj as Book).Price)
                return -1;
            return 0;
        }
    }
}
