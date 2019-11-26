using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BotFactory.Models
{
    public abstract class Wall_E : BaseUnit
    {
        public Wall_E(string name="Wall-E", double speed = 2) : base(name, speed)
        {
            BuildTime = 4;
        }
    }
}
