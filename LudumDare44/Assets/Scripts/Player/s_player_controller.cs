using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_player_controller : MonoBehaviour
{
    public float rotationSpeed = 0.7f;
    public Vector3[] postions;
    public GameObject parent;
    public float jumpForce = 2.0f;
    public Vector3 jump;
    public GameObject endMenu;
    public GameObject shop;
    private AudioSource jumpSound;
    Rigidbody rb;

    public GameObject particles;
    float timeSinceJump = 0;
    int currentPosition = 0;
    public bool canJump;



    //Pickups
    public bool unlockedShield = false;
    public GameObject shield;



    public bool unlockedMagnet = false;
    public bool unlockedDoublePoints = false;
    public bool unlockedDoubleJump = false;
    public bool canDoubleJump = false;




    // Start is called before the first frame update
    void Start()
    {
        if (unlockedShield)
        {
            shield.SetActive(true);
        }
        




        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        parent.transform.position = postions[currentPosition];
        jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        PlayerMovement();
        timeSinceJump += Time.deltaTime;

        
       
    }

    private void OnCollisionStay()
    {
        if (timeSinceJump > 1)
        {
            canJump = true;
            if (unlockedDoubleJump)
            {
                canDoubleJump = true;
            }
        }
    }


    void RotatePlayer()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * 100);
    }
    void PlayerMovement()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (currentPosition != 0)
            {
                currentPosition--;
                parent.transform.position = postions[currentPosition];
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (currentPosition != 2)
            {
                currentPosition++;
                parent.transform.position = postions[currentPosition];
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canJump)
            {
                canJump = false;
                timeSinceJump = 0;
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);


                jumpSound.Play();
            }
            else if (canDoubleJump)
            {
                canDoubleJump = false;
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);

            }

        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (shield.activeSelf == true)
            {
                Destroy(other.gameObject);
                shield.SetActive(false);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }

    private void OnDestroy()
    {
        particles.SetActive(true);
        endMenu.SetActive(true);
    }

    

}
