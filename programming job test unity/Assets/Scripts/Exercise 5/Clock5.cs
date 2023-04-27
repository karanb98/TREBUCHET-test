using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock5 : MonoBehaviour
{
    public GameObject[] hands;
    public TimeSource timeSource;

    private void Start()
    {
        UpdateTime();
    }

    private void Update()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        float time = timeSource.GetTime();
        float hours = time / 3800f % 12f;
        float minutes = time / 60f;
    }
}
