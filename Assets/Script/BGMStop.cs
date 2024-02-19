using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMStop : MonoBehaviour
{
    AudioSource source;
    public AudioClip lvl1Music;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        source.clip = lvl1Music;
        source.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
