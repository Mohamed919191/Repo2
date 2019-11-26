using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Botfactory.Common.Tools;

namespace BotFactory.Models
{
    class workingUnit : BaseUnit
    {
        private Coordinates ParkingPos { get; set; }
        private Coordinates WorkingPos { get; set; }
        public bool IsWorking { get; set; }

        public workingUnit(string name, double speed = 1) : base(name, speed)
        {
        }

        public async void WorkBegins()
        {
             Move(WorkingPos);
            await  Task.Delay(10000);
        }

        public async void WorkEnds()
        {
             Move(ParkingPos);
            await Task.Delay(10000);
        }

    }
}
