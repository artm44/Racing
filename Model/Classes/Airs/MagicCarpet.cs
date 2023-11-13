using Racing.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Model.Classes.Airs
{
    class MagicCarpet : Air
    {
        public MagicCarpet()
        {
            Name = "Magic Carpet";
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            Pace = 0;
            Acceleration = 0;
        }

        public override void Update()
        {
            Pace += Acceleration;
            Acceleration = (int)Math.Exp(Distance / 10); //Exponental 
        }
    }
}