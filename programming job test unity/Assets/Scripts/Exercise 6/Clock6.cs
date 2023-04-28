using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Clock6 : MonoBehaviour
{
    public Image hourHand;
    public Image minuteHand;
    public UnityEvent onHourPassed;

    private void Update()
    {
        // Get Current System Time
        System.DateTime now = System.DateTime.Now;

        // Calculate the angles for the hour hand and minute hand
        float hourAngle = (float)(-((now.Hour % 12) * 30 + now.Minute * 0.5));
        float minuteAngle = (float)(-(now.Minute * 6));

        // Set the rotation of the hour and minute hands
        hourHand.transform.rotation = Quaternion.Euler(0f, 0f, hourAngle);
        minuteHand.transform.rotation = Quaternion.Euler(0f, 0f, minuteAngle);

        if (now.Minute > 0f && now.Minute < 1f && Mathf.Abs(now.Hour - Mathf.Round(now.Hour)) < 0.1f)
        {
            onHourPassed.Invoke();
        }
    }
}
