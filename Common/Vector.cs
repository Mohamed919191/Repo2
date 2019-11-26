using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botfactory.Common.Tools;

namespace Botfactory.Common.Tools
{
  
       public class Vector
        {
            public double X;
            public double Y;
       
        


            public static Vector FromCoordinates(Coordinates begin, Coordinates end)
            {
                Vector Result = new Vector();

                Result.X = end.X - begin.X;
                Result.Y = end.Y - begin.Y;

                return Result;
            }

            public double length(Coordinates begin, Coordinates end)
            {
                return Math.Sqrt(Math.Exp(end.X - begin.X) + Math.Exp(end.Y - begin.Y));
            }
        }
    
}
