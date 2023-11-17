using Racing.Model.Abstractions;

namespace Racing.Model.Classes.Grounds
{
    class BootsRunners : Ground
    {
        public BootsRunners()
        {
            Name = "Boots Runners";
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            Pace = 16;
            TimeToRest = 0;
            TimeOfRest = 0;
        }

        protected override int NewTimeOfRest()
        {
            return TimeOfRest;
        }
    }
}
