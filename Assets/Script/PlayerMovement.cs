using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManager;
public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody2D rBody; 

    public GraundSensor sensor;

    public SpriteRenderer render;

    public Animator anim;

    AudioSource source;

    public Vector3 newPosition = new Vector3(50, 5, 0);

    public float jumpforce = 5;

    public float movementSpeed = 5;
    private float inputHorizontal;
    public bool jump = false;

    public AudioClip jumpSound; 

    public AudioClip deathSound;

    public Transform bulledSpeed;

    public Transform bulledPrefab;
    public Transform bulledSpawn;

    private bool canShoot = true;

    public float timer;
    public float reatOffire =1;

    public Transform hitBox;
    public float hitBox = 2;


    
   
   void Awake()
   {
    rBody = GetComponent<Rigidbody2D>();
    render = GetComponent <SpriteRenderer>();
    anim = GetComponent <Animator>();
    source = GetComponent <AudioSource>();
   }
    
    // Start is called before the first frame update
    void Start()

    {
        // Teletransporta al personaje a la posicion de la variable newPosition 
        transform.position = newPosition;

        
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        //transform.position = transform.position + new Vector3(1, 0, 0) * movementSpeed * Time.deltaTime;
        //
        transform.position += new Vector3(inputHorizontal, 0, 0) * movementSpeed * Time.deltaTime;

        

        /*if(jump == true)
        { 
            Debug.Log("Estoy saltando");
        }
        else if (jump == false)
        {
            Debug.Log("Estoy saltando");
        }
        else
        {
            Debug.Log("Estoy saltando");
        }*/

        Movment();

        Jump();

        Shoot();

        if(Imput.GetKeyDown(KeyCode.J))
        {
            Attack();
        }
    }
    
    void FixedUpdate() 
    {
      rBody.velocity = new Vector2(inputHorizontal * movementSpeed * Time.deltaTime, rBody.velocity.y);  
    }

    void Shoot()
    {
        if (!canShoot)
        {
            timer += Time.deltaTime;
            if(timer  >= reatOffire)
            {
                canShoot = true;

                timer = 0;
            }
        }
        if(Input.GetKeyDown(KeyCode.F) && canShoot)
        {
            Instantiate(bulledPrefab, bulledSpawn.position, bulledSpawn.rotation);

            canShoot =false;
        }
    }


    void Attack()
    {
        Collider2D[] enemies = Physics2D.OverlapcicleAll(hitBox.position, hitBoxRadius);

        foreach(Collider2D enemy in enemies)
        {
            if(enemy.gameObject.tag == "Goombas")
            {
                //Destroy(enemy.gameObject);
                Enemy enemyScript = enemy.GetComponent<Enemy>();
                enemyScript.GoombaDeath();
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmo.color = Color.Blue;
        Gizmo.DrawinreSphere(hitBox.position, hitBoxRadius);
    }

    void Movment()
   {
    if(inputHorizontal < 0)
            {
                transform.rotation = Quaternion.Euler(0, 100, 0);
                anim.SetBool("IsRunning", true);
            }
            else if (inputHorizontal > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                anim.SetBool("IsRunning", true);
            }
            else
            {
            anim.SetBool("IsRunning", false);   
            }
   }

   void Jump()
   {
     if(Input.GetButtonDown("Jump") && sensor.isGrounded == true)
        {
            
           rBody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
           anim.SetBool("IsJumping", true); 
           source.PlayOneShot(jumpSound);
        }
        
         if(Input.GetButtonDown("Jump") && sensor.isGrounded == true)
        {
            
           rBody.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
           anim.SetBool("IsJumping", true); 
        }
   }

   public void Death()
   {
    Source.PlayOneShot (deathSound)

    SceneManager.LoadScrean();
   }

   IEnumerator Die()
   {
    source.PlayOneShot(deathSound);

    yield return null;

    SceneManager.LoadScrean(0);
   }

}
