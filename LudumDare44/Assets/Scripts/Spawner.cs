using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] spawnableObjects;
    public Vector3[] spawnLocations;
    int locationToSpawn;
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitToSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        

    }    



    void SpawnObjects(int s, int f)
    {
        int objToSpawn = Random.Range(s, f);

        if (objToSpawn < 2)
        {
            locationToSpawn = Random.Range(0, 3);
        }
        else
        {
            locationToSpawn = Random.Range(0, 9);
        }
        

        GameObject tempObj = Instantiate(spawnableObjects[objToSpawn]);

        tempObj.transform.position = spawnLocations[locationToSpawn];

        
        int spawnExtras = Random.Range(0, 3);
        switch (spawnExtras)
           {
                case 1:
                    GameObject temp = Instantiate(tempObj);
                    temp.transform.position = new Vector3(tempObj.transform.position.x + 1.5f, tempObj.transform.position.y, tempObj.transform.position.z);
                    break;
                case 2:
                    GameObject temp1 = Instantiate(tempObj);
                    temp1.transform.position = new Vector3(tempObj.transform.position.x + 1.5f, tempObj.transform.position.y, tempObj.transform.position.z);

                    GameObject temp2 = Instantiate(tempObj);
                    temp2.transform.position = new Vector3(temp1.transform.position.x + 1.5f, temp1.transform.position.y, temp1.transform.position.z);

                    break;

        }

    }


    IEnumerator waitToSpawn()
    {
        while (true)
        {

            yield return new WaitForSeconds(Random.Range(1, 3));
            SpawnObjects(0,2);
            SpawnObjects(3, 6);


        }
    }
}
