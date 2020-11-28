using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{

    private float speed = 10.0f; 

    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Move the player forward and backward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Move the player left and right based on horizontal input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }

    }
}
