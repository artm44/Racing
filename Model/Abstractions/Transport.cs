
namespace Racing.Model.Abstractions
{
    abstract class Transport : IMoveable, IUpdateable
    {
        public string Name { get; protected set; }
        protected int Pace { get; set; }
        public int Distance { get; protected set; } = 0;
        public virtual void Move()
        {
            Distance += Pace; //реализовано равномерное движение за единицу времени
            Update();
        }
        public override string ToString() { return Name; }
        public abstract void Update();
        public virtual void Reset() { Distance = 0; }
    }
}
