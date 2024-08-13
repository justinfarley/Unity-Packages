using System;


namespace RedLobsterStudios.TimerUtils {
    public class IntervalTimer : Timer
    {
        public IntervalTimer(float endTime, bool countUp, Action endAction = null) : base(endTime, countUp, endAction)
        {
        }

        public override void Tick(float deltaTime)
        {
            base.Tick(deltaTime);
            if (Completed) //auto restart
                Restart();
        }
    }
}