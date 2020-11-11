using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smg : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int sprayCount = 0;
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Fire1") != 0 && GetComponent<gunStats>().canShoot)
        {
            if(sprayCount >= 90)
            {
                sprayCount = 0;
            }
            bulletPrefab = GetComponent<gunStats>().bulletPrefab;
            Vector3 bulletSpawnOffset = new Vector3(0, 0, transform.localScale.y);
            Quaternion camRotation = Camera.main.transform.rotation;
            Quaternion sprayRotation = Quaternion.Euler(camRotation.x, sprayCount + Random.Range(0,5) + camRotation.y - 45, camRotation.z);
            sprayCount += 12;
            Instantiate(bulletPrefab, transform.position + bulletSpawnOffset, sprayRotation);
            GetComponent<gunStats>().canShoot = false;
        }

    }
}
