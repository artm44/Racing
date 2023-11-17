﻿using Racing.Model.Abstractions;

namespace Racing.Model.Classes.Airs
{
    class FlyingShip : Air
    {
        public FlyingShip()
        {
            Name = "Flying Ship";
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            Pace = 20;
            Acceleration = 0;
        }

        public override void Update()
        {
            Pace += Acceleration;
            Acceleration = Acceleration + Distance <= 50 ? Acceleration + Distance : 50; //Linear 
        }
    }
}
