using UnityEngine;
using System.Collections;

public class EnemyMover : MonoBehaviour{



   public float speed;

   
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); 
    }


}
