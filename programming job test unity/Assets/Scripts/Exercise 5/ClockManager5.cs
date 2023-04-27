using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager5 : MonoBehaviour
{
    public GameObject clockPrefab;
    public TimeSource timeSource;

    public int numClocks;
    public float clockSpacing;

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
