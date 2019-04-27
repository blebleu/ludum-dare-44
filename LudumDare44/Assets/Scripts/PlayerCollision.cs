using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }


    private void OnTriggerEnter2D(Collider2D triggerCollider)
    {
        if (triggerCollider.tag == "Falling Spike")
        {
            Destroy(gameObject);
        }
    }


}


