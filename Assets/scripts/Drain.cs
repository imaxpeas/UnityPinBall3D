using UnityEngine;

public class Drain : MonoBehaviour
{
    [SerializeField] private Transform SpawnPos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("main ball"))
        {
            if (GameManager.LivesCount > 0)
            {
                Instantiate(other.gameObject).transform.position = SpawnPos.position;
                GameManager.LivesCount -= 1;
                Debug.Log("lost ball");
                Debug.Log("haha");

            }
            else
            {
                Debug.Log("game over hahaha");
            }
        }
        else if (other.CompareTag("extra"))
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