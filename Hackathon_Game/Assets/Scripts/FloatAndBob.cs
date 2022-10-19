using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatAndBob : MonoBehaviour
{
    // degrees per second
    public float rotationSpeed = 18.0f;
    public float height = 0.2f;
    public float speed = 0.7f;

    Vector3 posOffset = new Vector3 ();
    Vector3 tempPos = new Vector3 ();
 
    // Use this for initialization
    void Start () {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
    }
     
    // Update is called once per frame
    void Update () {
        // Spin object around Y-Axis
        transform.Rotate(new Vector3(0f, Time.deltaTime * rotationSpeed, 0f), Space.World);
 
        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * speed) * height;
 
        transform.position = tempPos;
    }
}

