namespace Racing.Model.Abstractions
{
    abstract class Air : Transport
    {
        protected int Acceleration { get; set; }

        public override void Update()
        {
            Pace += Acceleration;
            Acceleration = NewAcceleration();
        }
        protected abstract int NewAcceleration();
    }
}
