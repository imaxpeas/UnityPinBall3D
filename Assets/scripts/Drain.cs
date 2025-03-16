using UnityEngine;

public class Drain : MonoBehaviour
{
    [SerializeField] private Transform spawnPos;
    public GameObject BonusBall;
    [SerializeField] private Transform SpawnPos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("main ball"))
        {
            if (GameManager.BallCount > 0)
            {
                Instantiate(other.gameObject).transform.position = spawnPos.position;
                GameManager.BallCount -= 1;
                Debug.Log("lost ball");
                Debug.Log("haha");

                Instantiate(BonusBall).transform.position = SpawnPos.position;
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