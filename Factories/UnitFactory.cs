using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Botfactory.Common.Tools;
using Factories;

namespace BotFactories.Factories
{
    public class UnitFactory
    {
        private int _queueCapacity;        
        private int _StorageCapacity;
        private int queueFreeSlots;
        private int StorageFreeSlots;

        List<FactoryQueueElement> Queue;
        List<ITestingUnit> Storage;
        bool TmpFactoryBusy;

        public event EventHandler FactoryProgress;

        public UnitFactory(int queueCapacity, int StorageCapacity)
        {
            _queueCapacity = queueCapacity;
            _StorageCapacity = StorageCapacity;
        }

        public bool AddWorkableUnitToQueue(Type Model, string Name, Coordinates ParkingPos, Coordinates WorkingPos)
        {
            
            try
            {
                if (!TmpFactoryBusy)
                {
                    if (Queue.Count() < _queueCapacity)
                    {
                        if (Storage.Count() < _StorageCapacity)
                        {
                            TmpFactoryBusy = true;

                            var tmpElementqueue = new FactoryQueueElement();
                            tmpElementqueue.Model = Model;
                            tmpElementqueue.Name = Name;
                            tmpElementqueue.ParkingPos = ParkingPos;
                            tmpElementqueue.workingPos = WorkingPos;

                            Queue.Add(tmpElementqueue);
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }
            catch(Exception ex)
            {
                return false;
            }
            

            
        }


        protected virtual void OnFactoryProgress(EventArgs e)
        {
            if (Storage.Count() == _StorageCapacity || Queue.Count() != 0 )
            {
             EventHandler handler = FactoryProgress;
             handler?.Invoke(this, e);
            }
            
        }
    }
}
