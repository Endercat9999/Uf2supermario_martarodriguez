using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraundSensor : MonoBehaviour
{
    public bool isGrounded;
    public Animator anim;

    void Awake()
    {
        anim = GetComponentInParent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        isGrounded = true; 
        anim.SetBool("IsJumping", false);    
    }

    void OnTriggerExit2D(Collider2D collider) 
    {
        isGrounded = false;
    }
}
