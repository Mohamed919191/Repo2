using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BotFactory.Models
{
    public abstract class T_800 : BaseUnit
    {
        public T_800(string name = "T-800", double speed = 3) : base(name, speed)
        {
            BuildTime = 10;
        }
    }
}
