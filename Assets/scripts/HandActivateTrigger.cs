using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandActivateTrigger : MonoBehaviour
{
    [SerializeField] private Animator Hand;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Hand.SetTrigger("activate");
        }
    }
}
