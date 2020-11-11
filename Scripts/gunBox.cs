using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunBox : MonoBehaviour
{
    private int layerMask = 1 << 9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAround(transform.position, Vector3.up, 20 * Time.deltaTime);
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, transform.rotation,layerMask);
        if (hitColliders.Length != 0)
        {
            GameObject player = hitColliders[0].transform.root.gameObject;
            int randAmmo = Random.Range(0, 100);
            player.GetComponent<gunAmmos>().smgAmmos += randAmmo;
            Debug.Log(randAmmo);
            if (randAmmo < 5)
            {

            }
            else if (randAmmo < 15)
            {

            }
            else if (randAmmo < 70)
            {

            }
            else
            {
                //player.GetComponent<gunAmmos>().smgAmmos += randAmmo;
            }
            Destroy(gameObject);
        }
    }
}
