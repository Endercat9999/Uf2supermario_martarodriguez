using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float waitTime = 3f;

    public Transform spawnPoint;

    public bool activadeSpawn = false;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
       //InvokeRepeating("SpawnEnemy", 1f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        if(activadeSpawn)
        {
            SpawnEnemy();
        }
       
    }
    void SpawnEnemy()
    {
        timer += Time.deltaTime;

        if(timer >= waitTime)
        {
          Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

          timer = 0;  
        }

        //Instantiate(enemyPrefab, transform.position, transform.rotation);

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            activadeSpawn = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
        {
            if(collider.gameObject.tag == "Player")
            {
                activadeSpawn = false;
            }
        }
}
