using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public int damage = 10;
    public Transform ShootingPoint;


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
        }
    }

    void shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(ShootingPoint.position, ShootingPoint.right);

        if (hitInfo)
        {            
            
            enemy vihukainen = hitInfo.transform.GetComponent<enemy>();

            if (vihukainen != null)
            {
                vihukainen.takeDamage(damage);
            }
        }
    }


}
