using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    AddPoints Points;

    void Start()
    {
        Points = GameObject.find("HUD").FindObjectOfType<AddPoints>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide");
        if(collision.gameObject.name == "pixel_melon(Clone)") {
            Debug.Log("Fruit Collision");
            Points.fruitCollected();
            Destroy(collision.gameObject);
            // fire script to add points
            // fire script to place new fruit
        }

        else if(collision.gameObject.name == "Ghost") {
            Debug.Log("Ghost Collision");
            // fire script to end the game
        }
    }
}
