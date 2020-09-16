using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    //Sets the object for the camera to follow the player
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, 15);

    // Update is called once per frame
    void Update()
    {

        //Makes the main camera follow the players position
    transform.position = player.transform.position + offset;

    }
}
