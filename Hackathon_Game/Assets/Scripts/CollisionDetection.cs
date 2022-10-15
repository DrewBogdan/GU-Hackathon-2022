using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide");
        if(collision.gameObject.name == "Fruit") {
            Debug.Log("Fruit Collision");
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
