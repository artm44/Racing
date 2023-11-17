namespace Racing.Model.Abstractions
{
    abstract class Ground : Transport
    {
        public int TimeToRest;
        public int TimeOfRest;
        public int CntOfRest = 0;
        public int TimeFromLastChange = 0;
        public bool Rest = false;
        public override void Move()
        {
            if (!Rest)
                Distance += Pace;
            Update();
        }
    }
}
