using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    private GameObject bulletPrefab;
    public Camera cam;
    public int currentGun = 0;
    private GameObject gunsParent;
    public GameObject canvasGunsPanel;
    // Start is called before the first frame update
    void Start()
    {
        gunsParent = gameObject.transform.Find("Guns").gameObject;
        gunsParent.transform.GetChild(currentGun).gameObject.SetActive(true);
        canvasGunsPanel.transform.GetChild(currentGun).gameObject.GetComponent<UnityEngine.UI.Image>().color = Color.red;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetAxisRaw("Fire1") != 0)
        {
            for(int i = 0; i < gunsParent.transform.GetChild(currentGun).childCount; i++)
            {
                GameObject gun = gunsParent.transform.GetChild(currentGun).GetChild(i).gameObject;
                if (gun.GetComponent<gunStats>().canShoot)
                {
                }
            }
        }
        weaponChange();
    }
    void weaponChange()
    {
        for (int i = 1; i < 7; i++)
        {
            if (Input.GetKeyDown("" + i))
            {
                gunsParent.transform.GetChild(currentGun).gameObject.SetActive(false);
                canvasGunsPanel.transform.GetChild(currentGun).gameObject.GetComponent<UnityEngine.UI.Image>().color = Color.white;
                currentGun = i - 1;
                gunsParent.transform.GetChild(currentGun).gameObject.SetActive(true);
                canvasGunsPanel.transform.GetChild(currentGun).gameObject.GetComponent<UnityEngine.UI.Image>().color = Color.red;
            }
        }
    }
}
