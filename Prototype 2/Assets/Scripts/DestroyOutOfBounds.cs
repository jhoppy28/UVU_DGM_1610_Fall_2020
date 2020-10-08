using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30f;
    public float lowerBounds = -10f; 

    void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Destroys any object entering the topBounds
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }

        //Destroys any object entering the lowerBounds
        else if (transform.position.z < lowerBounds)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
