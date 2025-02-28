using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("apple"))
        {
            Debug.Log("apple is fell on table, +10 points!");
        }

        if (other.CompareTag("banana"))
        {
            Debug.Log("banana is fell on table, +30 points!!");
        }

        if (other.CompareTag("diamond"))
        {
            Debug.Log("diamond is fell on table, JACKPOT +9999999 points!!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
