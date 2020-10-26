using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Controls the player rigidbody
    private Rigidbody playerRB;

    //allows the jumpforce to be changed in the inspector
    public float jumpForce;

    //Allows the gravity modifier to be changed in the inspector
    public float gravityMod;
    
    public bool isGrounded = true;

    //Controls wether the game over state is active or not
    public bool gameOver = false;

    //Controls the player animation system
    private Animator playerAnim;

    //Controls the partical effect system
    public ParticleSystem explosionParticle;

    public ParticleSystem dirtParticle;

    //sound effects
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityMod;
        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true && !gameOver)
        {
            isGrounded = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
        dirtParticle.Play();

        if(other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if(other.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over");
            explosionParticle.Play();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            dirtParticle.Stop();
        }
    }
}
