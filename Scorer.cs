using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    void Start()
    {

    }

    int hits = 0;

    private void OnCollisionEnter(Collision other)
    {

        if(other.gameObject.tag != "Hit")
        {
            hits += 1;        
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }

    }
}
