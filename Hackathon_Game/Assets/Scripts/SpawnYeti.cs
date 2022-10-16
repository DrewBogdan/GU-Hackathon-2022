using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnYeti : MonoBehaviour
{
    public GameObject yetiPrefab;

    // Update is called once per frame
    private void Start()
    {
        Vector3 randomSpawnPos = new Vector3(Random.Range(-50, 51), -20, Random.Range(-50, 51));
        Instantiate(yetiPrefab, randomSpawnPos, Quaternion.identity);
    }
}
