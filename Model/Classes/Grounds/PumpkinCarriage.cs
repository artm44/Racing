using Racing.Model.Abstractions;

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
            Pace = 40;
            TimeToRest = 4;
            TimeOfRest = 40;
        }

        protected override int NewTimeOfRest()
        {
            return TimeOfRest - CntOfRest >= 1 ? TimeOfRest - CntOfRest : 1;
        }
    }
}
