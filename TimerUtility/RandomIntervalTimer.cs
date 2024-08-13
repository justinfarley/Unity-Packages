using System;

using UnityEngine;

public class RandomIntervalTimer : IntervalTimer
{
    private float lower;
    private float upper;
    public RandomIntervalTimer(float lowerBound, float upperBound, Action endAction = null) : base(UnityEngine.Random.Range(lowerBound, upperBound), false, endAction)
    {
        lower = lowerBound;
        upper = upperBound;
    }
    public override void Restart()
    {
        base.Restart();
        endTime = UnityEngine.Random.Range(lower, upper); // re-randomize
    }
}
