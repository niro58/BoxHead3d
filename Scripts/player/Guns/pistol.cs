using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistol : MonoBehaviour
{
    private GameObject bulletPrefab;
    private void FixedUpdate()
    {
        if(Input.GetAxisRaw("Fire1") != 0 && GetComponent<gunStats>().canShoot)
        {
            bulletPrefab = GetComponent<gunStats>().bulletPrefab;
            Vector3 bulletSpawnOffset = new Vector3(0, 0, transform.localScale.y);
            Instantiate(bulletPrefab, transform.position + bulletSpawnOffset, Camera.main.transform.rotation);
            GetComponent<gunStats>().canShoot = false;
        }
    }
}
