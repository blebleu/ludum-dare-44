using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_pickup : MonoBehaviour
   
{

    public float worth = .01f;
    public GameObject money;
    public float rotationSpeed;
    public AudioSource death;
    float tmpMoney;
    // Start is called before the first frame update
    void Start()
    {
        money = GameObject.FindGameObjectWithTag("Money");
            
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed, rotationSpeed, rotationSpeed);
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
