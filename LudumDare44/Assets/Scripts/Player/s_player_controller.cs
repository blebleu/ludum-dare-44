using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_player_controller : MonoBehaviour
{
    public float rotationSpeed = 0.7f;
    int currentPosition = 0;
    public Vector3[] postions;
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        parent.transform.position = postions[currentPosition];
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        PlayerMovement();
       
       
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
    }


}
