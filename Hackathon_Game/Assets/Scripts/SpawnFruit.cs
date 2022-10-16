using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    public GameObject fruitPrefab;
    public int amnt;
    void Start()
    {
        for (int i = 0; i < amnt; i++)
        {
            Vector3 randomSpawnPos = new Vector3(Random.Range(-5, 5), -1, Random.Range(-5, 5));
            Instantiate(fruitPrefab, randomSpawnPos, Quaternion.identity);
        }
    }
}
