using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugListener : MonoBehaviour
{
    private void Start()
    {
        // Find all clocks in the Scene and subscribe to their onHourPassed event
        Clock6[] clocks = FindObjectsOfType<Clock6>();
        foreach (Clock6 clock in clocks)
        {
            clock.onHourPassed.AddListener(OnHourPassed);
        }
    }

    private void OnHourPassed()
    {
        Debug.Log("The minute hand passed the hour hand!");
    }
}
