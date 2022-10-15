using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    public int points = 0;
    public int collected = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fruitCollected()
    {
        points += 50 * (collected+1);
        collected++;
    }
}
