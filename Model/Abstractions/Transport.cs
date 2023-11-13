using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Model.Abstractions
{
    abstract class Transport : IMoveable, IUpdateable
    {
        public string Name { get; protected set; }
        public int Pace { get; protected set; }
        public int Distance { get; protected set; } = 0;
        public virtual void Move()
        {
            Distance += Pace;
            Update();
        }
        public override string ToString() { return Name; }
        public abstract void Update();
        public virtual void Reset() { Distance = 0; }
    }
}
