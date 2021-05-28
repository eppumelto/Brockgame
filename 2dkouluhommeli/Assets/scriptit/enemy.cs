using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int health = 100;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Move()
    {
        transform.Translate(-1 * Time.deltaTime, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void takeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {            
            die();
        }

    }

     void die()
    {
        Destroy(gameObject);
    }
}
