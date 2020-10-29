using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //allows the objectPrefab to be selected in the inspector
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    //sets the delay for the first obstacles spawn
    private float startDelay = 2.0f;
    //sets a delay for the following obstacles spawn
    private float repeatDelay = 2.0f;
    //calls the playerController script
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        //Calls for the repeated spawning of barrels
        InvokeRepeating("SpawnObstacles", startDelay, repeatDelay);
        //Connects this script to the playerController script
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    //Activates InvokeRepeating and allows the obstacles to spawn
    void SpawnObstacles()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
