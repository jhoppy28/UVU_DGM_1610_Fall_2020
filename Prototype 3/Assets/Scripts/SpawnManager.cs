using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay;
    private float repeatDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn Obstacles", startDelay, repeatDelay);
    }

    void spawnObstacles()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
