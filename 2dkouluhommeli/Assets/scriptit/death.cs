using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class death : MonoBehaviour
{
    public GameObject deathpanel;
    public GameObject winnigs;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Player";
        deathpanel.SetActive(false);
        winnigs.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //tarkistetaan osuuko pelaaja voidiin tai maaliin
    public  void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Void")
        {
            deathpanel.SetActive(true);

            Destroy(player);
        }

        if (other.tag == "end")
        {
            winnigs.SetActive(true);

            Destroy(player);
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Vihollinen")
        {
            deathpanel.SetActive(true);

            Destroy(player);
        }
    }
}
