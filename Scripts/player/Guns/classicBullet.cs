using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class classicBullet : MonoBehaviour
{
    public float bulletThrust;
    public float bulletRange;
    public Quaternion cameraMidOffset;
    public GameObject aimCamera;
    private Vector3 cameraMid;
    // Start is called before the first frame update
    void Start()
    {
    }
    void Update()
    {
        bulletRange -= 1f;
        if(bulletRange == 0)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {

        transform.position += transform.forward * Time.deltaTime * bulletThrust;
        if (Physics.OverlapSphere(transform.position,0.21f).Count() != 0)
        {
            GameObject col = Physics.OverlapSphere(transform.position, 0.21f)[0].gameObject;
            GameObject colParent = Physics.OverlapSphere(transform.position, 0.21f)[0].transform.root.gameObject;
            if (colParent.layer == 11)
            {
                colParent.GetComponent<enemyStats>().health -= 1;
            }
            if(col.layer != 9 && col.layer != 8)
            {
                Destroy(gameObject);
            }
        }
    }
}
