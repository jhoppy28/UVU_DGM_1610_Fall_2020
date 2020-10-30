using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //sets the player speed
    private float speed = 10.0f;
    //sets horizontal input
    private float horizontalInput;
    //sets vertical input 
    private float verticalInput;
    //sets the player rigidbody
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //sets horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //sets vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //Move the player forward and backward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Move the player left and right based on horizontal input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
