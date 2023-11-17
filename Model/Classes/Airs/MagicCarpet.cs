using Racing.Model.Abstractions;
using System;

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

        protected override int NewAcceleration()
        {
            return (int)Math.Exp(Distance / 10); //Exponental  
        }
    }
}