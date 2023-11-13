using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Model.Abstractions
{
    abstract class Air : Transport
    {
        public int Acceleration { get; protected set; }
    }
}
