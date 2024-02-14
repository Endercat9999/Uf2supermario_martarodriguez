using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraundSensor : MonoBehaviour
{
    public bool isGrounded;
    public Animator anim;

    PlayerMovement playerScript;

    void Awake()
    {
        anim = GetComponentInParent<Animator>();
        playerScript = GetComponentInParent<PlayerMovement>();
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.tag == "Goombas")
        {
            playerScript.rBody.AddForce(Vector2.up * playerScript.jumpforce, ForceMode2D.Impulse);
            anim.SetBool ("IsJumping", true);

            //Destroy(collider.gameObject);
            Enemy goomba = collider.gameObject.GetComponent<Enemy>();

            goomba.GoombaDeath();
        }
        isGrounded = true; 
        anim.SetBool("IsJumping", false);    
    }

    void OnTriggerExit2D(Collider2D collider) 
    {
        isGrounded = false;
    }
}
