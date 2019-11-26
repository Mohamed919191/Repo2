using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Botfactory.Common.Tools;

namespace BotFactory.Models
{
    public abstract class BaseUnit : BuildableUnit
    {
        public string _Name;
        public double _Speed;
        public Coordinates currentPos = new Coordinates( 0, 0 );
        public Vector _vector;
        


        public BaseUnit(string name, double speed = 1)
        {
            _Name = name;
            _Speed = speed;

            _vector = new Vector();
            
        }

        public async Task<double> Move(Coordinates Vectpos)
        {
            double duration = await Task.Run(() =>(_vector.length(currentPos, Vectpos) / _Speed));

            return duration;
        }

        public string Name
        {
            get
            {
                return _Name;
            }
        }
    }
    }

