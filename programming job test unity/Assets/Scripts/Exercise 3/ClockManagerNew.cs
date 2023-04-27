using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClockManagerNew : MonoBehaviour
{
    public GameObject clockPrefab;
    public int numClocks;
    public float clockSpacing;
    public UnityEvent onClockAdded;

    private int numAddedClocks;

    private void Start()
    {
        InstantiateClocks(numClocks);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InstantiateClocks(1);

            onClockAdded.Invoke();
        }
    }

    private void InstantiateClocks(int numClocksToInstantiate)
    {
        for (int i = 0; i < numClocksToInstantiate; i++)
        {
            GameObject clock = Instantiate(clockPrefab);

            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-5f, 5f);
            Vector3 position = new Vector3(x, y, 0f) * clockSpacing;

            // Set the position of the clock
            clock.transform.SetParent(transform);
            clock.transform.localPosition = position;

            numAddedClocks++;
        }
    }
}
