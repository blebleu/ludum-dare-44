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

    Rigidbody rb;



    int currentPosition = 0;
    bool canJump;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        parent.transform.position = postions[currentPosition];
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        PlayerMovement();
       
       
    }

    private void OnCollisionStay()
    {
        canJump = true;
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
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            canJump = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);

        }
    }

    private void OnDestroy()
    {
        endMenu.SetActive(true);
    }

}
