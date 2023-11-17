using Racing.Model.Abstractions;

namespace Racing.Model.Classes.Airs
{
    class Broomstick : Air
    {
        public Broomstick()
        {
            Name = "Broomstick";
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            Pace = 50;
            Acceleration = 0;
        }

        public override void Update() {} //Constant
    }
}
