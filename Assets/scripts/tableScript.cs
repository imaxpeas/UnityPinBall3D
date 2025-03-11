using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableScript : MonoBehaviour
{
    public int TableScore;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("apple"))
        {
            Debug.Log("apple is fell on table, +10 points!");
            TableScore = TableScore + 10;
        }

        if (other.CompareTag("banana"))
        {
            Debug.Log("banana is fell on table, +30 points!!");
            TableScore = TableScore + 30;
        }

        if (other.CompareTag("diamond"))
        {
            Debug.Log("diamond is fell on table, JACKPOT +100 points!!");
            TableScore = TableScore + 100;
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
