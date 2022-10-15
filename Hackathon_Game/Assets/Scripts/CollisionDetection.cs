using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    AddPoints Points;

    void Start()
    {
        Points =FindObjectOfType<AddPoints>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide");
        if(collision.gameObject.name == "Fruit") {
            Debug.Log("Fruit Collision");
            Points.fruitCollected();
            // fire script to add points
            // fire script to place new fruit
        }

        else if(collision.gameObject.name == "Ghost") {
            Debug.Log("Ghost Collision");
            // fire script to end the game
        }
    }
}
