using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Racing.Model.Abstractions;

namespace Racing.Model.Classes
{
    class Race
    {
        public uint Distance { get; }
        public string Type { get;}
        public IEnumerable<Transport> Transports { get; }
        public IEnumerable<Transport> Winners { get; private set;  }
        private Race (uint dist, string type, IEnumerable<Transport> transports)
        {
            Distance = dist;
            Type = type;
            Transports = transports;
            Winners = null;
        }
        public static Race CreateRace<T>(uint dist, string type, IEnumerable<Transport> transports) where T : Transport
        {
            foreach (var transport in transports)
            {
                if (!(transport is T))
                {
                    return null;
                }
            }
            return new Race(dist, type, transports);
        }
        public void SimulateRace()
        {
            bool thereiswinner = false;
            var winners = new List<Transport>();
            while (!thereiswinner)
            {
                foreach (var transport in Transports)
                {
                    transport.Move();
                    if(transport.Distance >= Distance)
                    {
                        winners.Add(transport);
                        thereiswinner = true;
                    }
                }
            }
            foreach (var transport in Transports) { transport.Reset(); }
            Winners = winners;
        }
    }
}
