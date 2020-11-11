using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunStats : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float shootColdownLive;
    public float shootCooldownTime;
    public bool canShoot = true;
    void FixedUpdate()
    {

        if (canShoot == false)
        {
            shootColdownLive -= Time.deltaTime;
            if(shootColdownLive <= 0)
            {
                shootColdownLive = shootCooldownTime;
                canShoot = true;
            }
        }
    }
}
