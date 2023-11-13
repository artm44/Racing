using Racing.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Model.Classes.Grounds
{
    class Centaur : Ground
    {
        public Centaur()
        {
            Name = "Centaur";
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            Pace = 30;
            TimeToRest = 10;
            TimeOfRest = 4;
        }

        public override void Update()
        {
            TimeFromLastChange++;
            if (TimeFromLastChange == TimeOfRest || TimeFromLastChange == TimeToRest)
            {
                if (Rest)
                {
                    CntOfRest++;
                    TimeOfRest += CntOfRest;
                }
                TimeFromLastChange = 0;
                Rest = !Rest;
            }
        }
    }
}
