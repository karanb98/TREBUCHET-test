using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ElapsedTimeSource", menuName = "TimeSource/ElapsedTimeSource")]
public class ElapsedTimeSource : TimeSource
{
    [SerializeField] private float timeMultiplier = 1f;

    public override float GetTime()
    {
        return Time.time * timeMultiplier;
    }
}
