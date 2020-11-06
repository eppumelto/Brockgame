using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   
    public Rigidbody2D rb;
    public float speed = 12f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public void move()
    {
        float x = Input.GetAxis("Horizontal");
        float moveby = x * speed;
        rb.velocity = new Vector2(moveby, rb.velocity.y);
    }
}
