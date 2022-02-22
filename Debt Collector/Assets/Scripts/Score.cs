using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;

    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Debt collected: " + score.ToString() + "$";
    }

    
    public void AddCash()
    {
        score++;
        scoreText.text = "Debt collected: " + score.ToString() + "$";

    }
}
