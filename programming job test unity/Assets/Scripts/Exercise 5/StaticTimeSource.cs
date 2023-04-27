using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StaticTimeSource", menuName = "TimeSource/StaticTimeSource")]
public class StaticTimeSource : TimeSource
{
    [SerializeField] private float time;

    public override float GetTime()
    {
        return time;
    }
}
