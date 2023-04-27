using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    public GameObject clockPrefab;
    public int numClocks;

    private void Start()
    {
        for (int i = 0; i < numClocks; i++)
        {
            // Create a new clock instance
            GameObject clock = Instantiate(clockPrefab);
            Debug.Log("Working");

            // Calculate the position of the clock
            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-5f, 5f);
            Vector3 position = new Vector3(x, y, 0f) * 40;

            // Set the position of the clock
            clock.transform.SetParent(transform);
            clock.transform.localPosition = position;
        }
    }
}
