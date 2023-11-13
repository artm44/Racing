using Racing.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Model.Classes.Airs
{
    class BabaYagaStupa : Air
    {
        public BabaYagaStupa()
        {
            Name = "Baba Yaga Stupa";
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            Pace = 0;
            Acceleration = 50;
        }

        public override void Update()
        {
            Pace += Acceleration;
            Acceleration = Acceleration - Distance >= 0 ? Acceleration - Distance : 0; //Linear 
        }
    }
}
