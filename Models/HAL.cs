using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BotFactory.Models
{
    public abstract class HAL : BaseUnit
    {
        public HAL(string name = "HAL", double speed = 0.5) : base(name, speed)
        {
            BuildTime = 7;
        }
    }
}
