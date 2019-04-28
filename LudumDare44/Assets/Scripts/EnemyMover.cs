using UnityEngine;
using System.Collections;

public class EnemyMover : MonoBehaviour{



   public float speed;
    private Vector2 screenBounds;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }


    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World); 
        if (transform.position.x < screenBounds.x * 2)
        {
            Destroy(this.gameObject);
        }
    }


}
