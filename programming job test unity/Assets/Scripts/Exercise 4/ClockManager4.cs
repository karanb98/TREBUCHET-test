using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager4 : MonoBehaviour
{
    public GameObject clockPrefab;
    public GameObject cylinderClock;
    public GameObject cubicClock;
    public GameObject triangleClock;

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
            InstantiateRandomClock((int)(Random.Range(0, 3)));
        }
    }

    private void InstantiateRandomClock(int randomIndex)
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-5f, 5f);

        Vector3 position = new Vector3(x, y, 0f) * clockSpacing;

        switch(randomIndex)
        {
            case 0:
                GameObject randomClock0 = Instantiate(cubicClock);

                randomClock0.transform.SetParent(transform);
                randomClock0.transform.localPosition = position;

                break;
            case 1:
                GameObject randomClock1 = Instantiate(cylinderClock);

                randomClock1.transform.SetParent(transform);
                randomClock1.transform.localPosition = position;

                break;
            case 2:
                GameObject randomClock2 = Instantiate(triangleClock);

                randomClock2.transform.SetParent(transform);
                randomClock2.transform.localPosition = position;

                break;
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
