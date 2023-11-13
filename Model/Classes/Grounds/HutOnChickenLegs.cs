using Racing.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Model.Classes.Grounds
{
    class HutOnChickenLegs : Ground
    {
        public HutOnChickenLegs()
        {
            Name = "Hut on chicken legs";
            Reset();
        }
        public override void Reset()
        {
            base.Reset();
            Pace = 40;
            TimeToRest = 20;
            TimeOfRest = 20;
        }

        public override void Update()
        {
            TimeFromLastChange++;
            if (TimeFromLastChange == TimeOfRest || TimeFromLastChange == TimeToRest)
            {
                if (Rest)
                {
                    CntOfRest++;
                    TimeOfRest = CntOfRest % 2 == 0 ? 20 : 10;
                }
                TimeFromLastChange = 0;
                Rest = !Rest;
            }
        }
    }
}

