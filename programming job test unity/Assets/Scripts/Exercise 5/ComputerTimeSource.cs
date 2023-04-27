using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ComputerTimeSource", menuName = "TimeSource/ComputerTimeSource")]
public class ComputerTimeSource : TimeSource
{
    public override float GetTime()
    {
        return Time.time;
    }
}
