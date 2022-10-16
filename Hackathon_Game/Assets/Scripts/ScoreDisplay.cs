using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Points : " + score;
    }
}
