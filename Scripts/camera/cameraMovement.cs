using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public float sensitivityX = 2f;
    public float sensitivityY = 2f;
    public float rotationX;
    public float rotationY;
    public GameObject player;
    public GameObject playerHeadChild;
    public Vector3 playerCameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = playerHeadChild.transform.position;
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        rotationX += Input.GetAxis("Mouse X") * sensitivityX;
        rotationY += -Input.GetAxis("Mouse Y") * sensitivityY;
        if(rotationY >= 70)
        {
            transform.rotation = Quaternion.Euler(70, transform.rotation.y + rotationX, 0);
            rotationY = 70;
        }
        else if (rotationY <= -90)
        {
            transform.rotation = Quaternion.Euler(-90, transform.rotation.y + rotationX, 0);
            rotationY = -90;
        }
        else
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x + rotationY, transform.rotation.y + rotationX, 0);
        }
        
        player.transform.rotation = Quaternion.Euler(0,transform.rotation.y + rotationX, 0);

        
    }
}
