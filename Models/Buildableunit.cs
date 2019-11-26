using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace BotFactory.Models
{
    public abstract class BuildableUnit : ReportingUnit
    {
        public double BuildTime;
        string Model;
        public BuildableUnit(double _buildtime = 5)
        {
            BuildTime = _buildtime;
        }
    }
}
