using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour

{
    [SerializeField] private Animator RightFlipper;
    [SerializeField] private Animator LeftFlipper;
    [SerializeField] private Animator plunger;
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
    private void plungerControl()
    {
        AnimatorStateInfo stateInfo = plunger.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKey(KeyCode.Space))
        {
            if (stateInfo.normalizedTime < 0)
            {
                plunger.SetFloat("", 0);
            }
            else
            {
                plunger.SetFloat("", -1);
            }
        }
        else
        {
            if (stateInfo.normalizedTime > 1)
            {
                plunger.SetFloat("", 0);
            }
            else
            {
                plunger.SetFloat("", 1);
            }
        }
    }
}
