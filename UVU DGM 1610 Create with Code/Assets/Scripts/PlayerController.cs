using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;

    public float turnSpeed;

    public float hInput;

    public float fInput;


    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * hInput);
    }
}