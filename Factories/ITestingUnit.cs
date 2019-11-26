using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botfactory.Common.Tools;

namespace BotFactories.Factories
{
    public interface ITestingUnit
    {
        string _Name { get; set; }
        double _Speed { get; set; }
        Coordinates currentPos { get; set; }
        Vector _vector { get; set; }

    }
}
