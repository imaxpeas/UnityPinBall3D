using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumperScript : MonoBehaviour
{
    [SerializeField] private Animator bumper;
    private int BumperMainball = 10;
    private int BumperBonusBall = 50;
    private void OnCollisionEnter(Collision collision)
    {
        bumper.SetTrigger("bang");
        if (collision.collider.CompareTag("main ball"))
        {
            GameManager.GameScore = GameManager.GameScore + BumperMainball;
        }
        else if (collision.collider.CompareTag("bonus ball"))
        {
            GameManager.GameScore = GameManager.GameScore + BumperBonusBall;
        }
        Debug.Log(GameManager.GameScore);
    }

}