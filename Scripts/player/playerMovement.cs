using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveThrust;
    private Animator animator;
    private Rigidbody playerRb;
    public int health = 5;
    public bool canTakeDamage = true;
    public float canTakeDamageCooldown;
    private float canTakeDamageTime;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerRb.AddForce(transform.position + (transform.forward * Input.GetAxisRaw("Vertical") * moveThrust + (transform.right * Input.GetAxisRaw("Horizontal")) * moveThrust));
        
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            animator.SetFloat("Blend", 1);
        }
        else
        {
            animator.SetFloat("Blend", 0);
        }
        if(canTakeDamage)
        {
            canTakeDamageTime = canTakeDamageCooldown;
        }
        else
        {
            canTakeDamageTime -= Time.deltaTime;
            if (canTakeDamageTime <= 0)
            {
                canTakeDamage = true;
            }
        }

    }
}
