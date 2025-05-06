using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slingshotScript : MonoBehaviour
{
    [SerializeField] private Animator bumper;
    private int slingShotMainball = 30;
    private int slingShotBonusBall = 150;
    private void OnCollisionEnter(Collision collision)
    {
        if (bumper != null)
        {
            bumper.SetTrigger("bang");
        }
        if (collision.collider.CompareTag("main ball"))
        {
            GameManager.GameScore = GameManager.GameScore + slingShotMainball;
        }
        else if (collision.collider.CompareTag("bonus ball"))
        {
            GameManager.GameScore = GameManager.GameScore + slingShotBonusBall;
        }
        Debug.Log(GameManager.GameScore);
    }

}