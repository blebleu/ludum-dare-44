using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_pickup : MonoBehaviour
   
{

    public float worth = .01f;
    public GameObject money;
    public float rotationSpeed;
    bool magnet = false;
    bool timestwo = false;
    //public AudioSource death;



    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        money = GameObject.FindGameObjectWithTag("Money");
        player = GameObject.FindGameObjectWithTag("Player");

        if (player != null) { 
        magnet = player.GetComponent<s_player_controller>().unlockedMagnet;
        timestwo = player.GetComponent<s_player_controller>().unlockedDoublePoints;
        }
        if (timestwo)
        {
            worth = worth * 2;
        }
        



    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed, rotationSpeed, rotationSpeed);
        if (player != null)
        {
            if (magnet && (player.transform.position.z == transform.position.z))
            {
                if ((transform.position.y - player.transform.position.y < .05) && (transform.position.y - player.transform.position.y > 0))
                {

                }
                else if (transform.position.y > player.transform.position.y)
                {
                    transform.Translate(Vector3.down * 2 * Time.deltaTime, Space.World);
                }
                else if (transform.position.y < player.transform.position.y)
                {
                    transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);
                }
            }
        }
    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) { 
            money.GetComponent<s_money>().moneyTotal += worth;
            AudioSource temp = money.GetComponent<AudioSource>();
            temp.Play();
            PlayerPrefs.SetFloat("Total", PlayerPrefs.GetFloat("Total",0) + worth);
            Destroy(this.gameObject);
        }
    }
}
