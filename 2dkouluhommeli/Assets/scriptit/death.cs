using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class death : MonoBehaviour
{
    public GameObject deathpanel;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Player";
        deathpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Void")
        {
            deathpanel.SetActive(true);

            Destroy(player);
        }
    }
}
