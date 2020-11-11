using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (gameObject.transform.root.GetComponent<playerMovement>().canTakeDamage == true && col.gameObject.layer == 11)
        {
            gameObject.transform.root.GetComponent<playerMovement>().health -= 1;
            gameObject.transform.root.GetComponent<playerMovement>().canTakeDamage = false;
            Debug.Log("got damage");
            Debug.Log(gameObject.transform.root.GetComponent<playerMovement>().canTakeDamage);

        }
    }
}
