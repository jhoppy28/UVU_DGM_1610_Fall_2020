using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int speed = 20;

    private float turnSpeed = 100;

    private float hInput;

    private float fInput;


    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        //Rotates the vehicle left and right based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * hInput);
    }
}