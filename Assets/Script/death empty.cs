using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class deathempty : MonoBehaviour
{
    private Rigidbody2D rBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     public void LoadDeathscene()
    {
        SceneManager.LoadScene("Death scene");
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Death scene");
        }
    }
    void Update()
    {
        rBody = GetComponent<Rigidbody2D>();
    }
}
