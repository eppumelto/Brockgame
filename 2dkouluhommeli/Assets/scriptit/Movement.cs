using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   
    public Rigidbody2D rb;
    public float speed = 12f;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        move();
        Boost();
    }

    public void move()
    {
        float x = Input.GetAxis("Horizontal");
        float moveby = x * speed;
        rb.velocity = new Vector2(moveby, rb.velocity.y);
    }

    public void Boost ()
    {
        if (Input.GetButton("Boost"))
        {
            speed = 50f;
            transform.rotation = Quaternion.Euler(0, -180, -30);
            audioSource.Play();
        }
        else
        {
            speed = 12f;
                    }
    }
}
