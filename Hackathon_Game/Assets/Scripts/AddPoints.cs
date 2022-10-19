using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    public int points = 0;
    public int collected = 0;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide");
        if(collision.gameObject.name == "pixel_melon(Clone)") {
            Debug.Log("Fruit Collision");
            Destroy(collision.gameObject);
            points++;
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
    
    public void fruitCollected()
    {
        points += 50 * (collected+1);
        collected++;
        //HUD.FindObjectOfType<Points>().FindObjectOfType<PointScript>().PointUpdate(points);
    }
}
