using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
   
    public Rigidbody2D rb;
    public float speed = 12f;
    public AudioSource audioSource;
    public float rollSpeed = 2f;

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
        Rotate();
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
            audioSource.Play();
        }
        else
        {
            speed = 12f;
                    }
    }

    public void Rotate()
    {
        if (Input.GetButton("Rollforward")) {
            transform.Rotate(Vector3.back * rollSpeed);
            UnityEngine.Debug.Log("juu");
        }
        if (Input.GetButton("Rollback"))
        {
            transform.Rotate(Vector3.forward * rollSpeed);
            UnityEngine.Debug.Log("juu");
        }
    }
}
