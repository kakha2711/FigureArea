using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public abstract class Figura : Comparable
    {
        public abstract double GetArea();

        public string FigureName
        {
            get
            {
                return this.GetType().Name;//gvadzlevs mimdinare klasis obieqtis saxels
            }
        }

        public override string ToString()
        {
            return $"{FigureName} Area is: {GetArea()}";
        }

        public override int CompareTo(object obj)
        {
            double area1 = this.GetArea();
            double area2 = (obj as Figura).GetArea();

            if (area1 > area2)
                return 1;
            else if (area1 < area2)
                return -1;
            return 0;
        }
    }
}
