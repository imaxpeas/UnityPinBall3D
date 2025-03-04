using UnityEngine;

public class Drain : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("main ball"))
        {

            if (GameManager.BallCount > 0)
            {
                GameManager.BallCount -= 1;
                Debug.Log("lost ball");
                Debug.Log("haha");
            }
            else
            {
                Debug.Log("game over hahaha");
            }
        }
        else if(other.CompareTag("extra"))
        {
            Debug.Log("it's extra");
        }
        else
        {
            Debug.Log("watahell");
        }
        Destroy(other.gameObject);
    }

}
