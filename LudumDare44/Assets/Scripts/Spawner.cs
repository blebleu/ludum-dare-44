using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Projectile_DarkSpikePrefab;
    public float secondsBetweenSpawns;
    float nextSpawnTime;
    public float spawnAngleMax;

    Vector2 screenHalfSizeWorldUnits;

    // Start is called before the first frame update
    void Start()
    {
        screenHalfSizeWorldUnits = new Vector2 (Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);   
    }

    // Update is called once per frame
    void Update()
    {


        if (Time.time > nextSpawnTime)
        {
         
            nextSpawnTime = Time.time + secondsBetweenSpawns;
            float spawnAngle = Random.Range(-spawnAngleMax, spawnAngleMax);
            Vector2 spawnPosition = new Vector2(Random.Range(-75, 75), screenHalfSizeWorldUnits.y);
            Instantiate(Projectile_DarkSpikePrefab, spawnPosition, Quaternion.Euler(Vector3.forward * spawnAngle));
            
        }
    }
}
