using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubescript : MonoBehaviour
{
    [SerializeField] [Range(0, 100)] float speed = 5f; 
    [Space]
    [SerializeField] GameObject blin;
    [Space]
    [SerializeField] GameObject Vova;
    [Space]
    [SerializeField] GameObject shar;
    [Space]
    [SerializeField] string cubescriptName = "VENOMCUBE";
    // Start is called before the first frame update
    void Start()
    {
     gameObject.name = cubescriptName;
        blin.name = "blinchik";
        Vova.name = "AMOGUS";       
        shar.name = "mouse";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
