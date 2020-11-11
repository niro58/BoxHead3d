using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smg : MonoBehaviour
{
    private GameObject bulletPrefab;
    public int sprayCount = 0;
    private GameObject firePoint;
    private void Start()
    {
        firePoint = gameObject.transform.Find("firePoint").gameObject;
    }
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(Camera.main.transform.eulerAngles.x, Camera.main.transform.eulerAngles.y, Camera.main.transform.eulerAngles.z);
        if (Input.GetAxisRaw("Fire1") != 0 && GetComponent<gunStats>().canShoot && transform.root.GetComponent<gunAmmos>().smgAmmos != 0)
        {
            if(sprayCount >= 5)
            {
                sprayCount = 0;
            }
            bulletPrefab = GetComponent<gunStats>().bulletPrefab;
            Quaternion sprayRotation = Quaternion.Euler(Random.Range(-5, 5),Random.Range(-5, 5), 0) * Camera.main.transform.rotation;
            sprayCount += 2;
            Instantiate(bulletPrefab, firePoint.transform.position, sprayRotation);
            transform.root.GetComponent<gunAmmos>().smgAmmos -= 1;
            GetComponent<gunStats>().canShoot = false;
        }

    }
}
