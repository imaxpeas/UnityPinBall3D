using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drain : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.name == "") 
        {
            Debug.Log("lose");
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
