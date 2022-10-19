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

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide");
        if(collision.gameObject.name == "pixel_melon(Clone)") {
            Debug.Log("Fruit Collision");
            Destroy(collision.gameObject);
            score++;
            // fire script to add points
            // fire script to place new fruit
        }

        else if(collision.gameObject.name == "Ghost") {
            Debug.Log("Ghost Collision");
            // fire script to end the game
        }
        else if(collision.gameObject.name == "pixel_melon") {
            Debug.Log("Fruit Collision");
            Destroy(collision.gameObject);
            // fire script to add points
            // fire script to place new fruit
        }
    }
    void FixedUpdate() {
          
    }

    public void PointUpdate(int point)
    {
        score = point;
    }
}
