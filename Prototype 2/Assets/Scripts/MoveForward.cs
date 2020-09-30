using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 40f; 

    // Update is called once per frame
    void Update()
    {
        //Moves whatever script is attached to forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
