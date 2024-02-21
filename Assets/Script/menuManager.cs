using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    public Text scoreText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        LoadScore();
    }
    void LoadScore()
    {
        scoreText.text = "Puntuacion:" + score.ToString();
    }

    public void LoadFirtsLevel()
    {
        SceneManager.LoadScene("nivel 1");
    }
}
