using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botfactory.Common.Tools
{
    public class Coordinates
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Coordinates(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override bool Equals(object obj)
        {
            Coordinates tmp = (Coordinates)obj;

            if (this.X == tmp.X && this.Y == tmp.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


}
