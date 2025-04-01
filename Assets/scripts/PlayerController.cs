using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator RightFlipper;
    [SerializeField] private Animator LeftFlipper;
    private void Update()
    {
        FlipperControl();
    }
    private void FlipperControl()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightFlipper.SetTrigger("push");
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftFlipper.SetTrigger("push");
        }

    }
}
