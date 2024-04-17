using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game Manager : MonoBehaviour
{
  public list<GameObjects> enemisInScrean;  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            DestroyEnemisInScrean();
        }
    }

    public void DestroyenEmisInScrean()
    {
        foreach(GameObject enemy in enemysInScrean)
        {
            Destroy(enemy);
        }
    }
}
