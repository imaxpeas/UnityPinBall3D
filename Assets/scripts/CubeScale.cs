using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScale : MonoBehaviour
{
    [SerializeField] private Animator Cube;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Cube.SetTrigger("scale");
        }
    }
}
