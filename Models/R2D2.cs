using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BotFactory.Models
{
    public abstract class R2D2 : BaseUnit
    {
        public R2D2(string name = "R2D2", double speed = 1.5) : base(name, speed)
        {
            BuildTime = 5.5;
        }
    }
}
