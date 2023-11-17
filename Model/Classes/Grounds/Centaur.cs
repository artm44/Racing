using Racing.Model.Abstractions;

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
            Pace = 20;
            TimeToRest = 10;
            TimeOfRest = 4;
        }

        protected override int NewTimeOfRest()
        {
            return TimeOfRest + CntOfRest;
        }
    }
}
