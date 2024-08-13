using System;

public class Timer
{
    #region Fields

    protected bool countUp = false;
    
    private bool _completed = false;
    public bool Completed => _completed;

    private float time;
    protected float endTime;

    private Action endAction;

    #endregion

    #region Life Cycle
    protected Timer(float endTime, bool countUp, Action endAction = null)
    {
        this.countUp = countUp;
        this.endTime = endTime;
        time = countUp ? 0f : endTime;
        this.endAction = endAction;
    }

    #endregion

    #region Private API

    private void CountUp(float deltaTime)
    {
        if (!countUp) return;
        
        time += deltaTime;

        if (time < endTime) return;
        
        _completed = true;
        endAction?.Invoke();
    }

    private void CountDown(float deltaTime)
    {
        if(countUp) return;

        time -= deltaTime;

        if (time > 0f) return;
        
        _completed = true;
        endAction?.Invoke();
    }

    #endregion

    #region Public API


    public virtual void Tick(float deltaTime)
    {
        if (_completed) return;

        CountUp(deltaTime);
        CountDown(deltaTime);
    }
    public virtual void Restart()
    {
        time = countUp ? 0f : endTime;
        _completed = false;
    }
    public static Timer CreateTimer(float endTime, bool countUp) => new Timer(endTime, countUp);

    #endregion
}
