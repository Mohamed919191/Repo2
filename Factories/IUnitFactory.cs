using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactories.Factories
{
    class IUnitFactory
    {
        private int _queueCapacity;
        private int _StorageCapacity;
        private int queueFreeSlots;
        private int StorageFreeSlots;

        List<FactoryQueueElement> Queue;
        List<ITestingUnit> Storage;
    }
}
