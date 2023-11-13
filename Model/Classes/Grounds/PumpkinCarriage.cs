using Racing.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Model.Classes.Grounds
{
    class PumpkinCarriage : Ground
    {
        public PumpkinCarriage()
        {
            Name = "Pumpkin Carriage";
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            Pace = 60;
            TimeToRest = 10;
            TimeOfRest = 100;
        }

        public override void Update()
        {
            TimeFromLastChange++;
            if (TimeFromLastChange == TimeOfRest || TimeFromLastChange == TimeToRest)
            {
                if (Rest)
                {
                    CntOfRest++;
                    TimeOfRest = TimeOfRest - CntOfRest >= 1 ? TimeOfRest - CntOfRest : 1;
                }
                TimeFromLastChange = 0;
                Rest = !Rest;
            }
        }
    }
}
