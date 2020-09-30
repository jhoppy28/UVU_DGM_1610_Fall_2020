using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBounds = 30f;
    public float lowerBounds = -10f; 

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
            Destroy(gameObject);
        }
    }
}
