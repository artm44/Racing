using Racing.Model.Abstractions;

namespace Racing.Model.Classes.Airs
{
    class BabaYagaStupa : Air
    {
        public BabaYagaStupa()
        {
            Name = "Baba Yaga Stupa";
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            Pace = 0;
            Acceleration = 50;
        }

        protected override int NewAcceleration()
        {
            return Acceleration - Distance >= 0 ? Acceleration - Distance : 0; //Linear 
        }
    }
}
