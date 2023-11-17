namespace Racing.Model.Abstractions
{
    abstract class Ground : Transport
    {
        protected int TimeToRest;
        protected int TimeOfRest;
        protected int CntOfRest = 0;
        protected int TimeFromLastChange = 0;
        protected bool Rest = false;
        public override void Move()
        {
            if (!Rest)
                Distance += Pace;
            Update();
        }
        public override void Reset() {
            base.Reset();
            Rest = false;
            CntOfRest = 0;
            TimeFromLastChange = 0;
        }
        public override void Update()
        {
            TimeFromLastChange++;
            if (TimeFromLastChange == TimeOfRest && Rest)
            {
                CntOfRest++;
                TimeOfRest = NewTimeOfRest();
                TimeFromLastChange = 0;
                Rest = !Rest;
            }
            else if (!Rest && TimeFromLastChange == TimeToRest)
            {
                TimeFromLastChange = 0;
                Rest = !Rest;
            }
        }
        protected abstract int NewTimeOfRest();
    }
}
