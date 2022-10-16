using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    public GameObject player;
    public float speed = 4f;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
