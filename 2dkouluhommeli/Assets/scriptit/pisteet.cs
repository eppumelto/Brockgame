using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pisteet : MonoBehaviour
{
    public Text Score;
    public int ScoreCount;
    public GameObject piste;


    // Start is called before the first frame update
    void Start()
    {
        Score.text = "Pisteet: ";
       
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        ScoreCount  += 1;

        if (other.tag == "Piste")
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Pisteet: " + ScoreCount;
    }
}
