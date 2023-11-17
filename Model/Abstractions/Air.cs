namespace Racing.Model.Abstractions
{
    abstract class Air : Transport
    {
        public int Acceleration { get; protected set; }
    }
}
