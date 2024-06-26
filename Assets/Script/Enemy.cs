using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

 

public class Enemy : MonoBehaviour



{
    public AudioSource source;

    private GameManager gameManager;

    public AudioClip deathSound;

    private BoxCollider2D boxColider; 

    private Rigidbody2D rBody;

    public float enemySpeed = 5;

    public float enemyDirection = 1;

    // Start is called before the first frame update
    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        boxColider = GetComponent <BoxCollider2D>();
        gameManager = GameObject.Find("Game manager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rBody.velocity = new Vector2(enemyDirection * enemySpeed, rBody.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 3 || collision.gameObject.tag == "Goombas")
        {
            if(enemyDirection == 1)
        {
            enemyDirection = -1;
        }
        else if(enemyDirection == -1)
        {
            enemyDirection = 1;
        }
        }

        if(collision.gameObject.tag == "Player")
        {
            PlayerMovement playerScript = collision.gameObject.GetComponent<PlayerMovement>();

            playerScript.Death();
        }
        
    }
    public void LoadDeathscene()
    {
        SceneManager.LoadScene("Death scene");
        
    }
    public void GoombaDeath()
    {
        source.PlayOneShot(deathSound);
        boxColider.enabled = false;
        rBody.gravityScale = 0; 
        enemyDirection = 0; 
        Destroy(gameObject, 0.5f);

    }

    void OnBecameVisible()
    {
        gameManager.enemisInScrean.Add(this.gameObject);
    }

    void OnBecameInvisible()
    {
        gameManager.enemisInScrean.Remove(this.gameObject);
    }
}
