using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public int damage = 10;
    public Transform ShootingPoint;
    public AudioSource gunshot;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
            gunshot.Play();
        }
    }

    //´Metodi jossa tarkistetaan osutaanko viholliseen
    void shoot()
    {   //luodaan raycast joka tarkistaa jos osutaan
        RaycastHit2D hitInfo = Physics2D.Raycast(ShootingPoint.position, ShootingPoint.right);


        if (hitInfo)
        {            
            //jos osutaan kutsutaan metodi takedamage
            enemy vihukainen = hitInfo.transform.GetComponent<enemy>();

            if (vihukainen != null)
            {
                vihukainen.takeDamage(damage);
            }
        }
    }


}
