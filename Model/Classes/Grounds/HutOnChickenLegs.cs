using Racing.Model.Abstractions;

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
            Pace = 25;
            TimeToRest = 10;
            TimeOfRest = 20;
        }

        protected override int NewTimeOfRest()
        {
            return CntOfRest % 2 == 0 ? 20 : 10;
        }
    }
}

