using UnityEngine;
public class BonusBallScript : MonoBehaviour
{
    [SerializeField] private GameObject bonusBall;
    [SerializeField] private Transform spawnPos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Main Ball"))
        {
            Instantiate(bonusBall).transform.position = spawnPos.position; 
        }
    }
}

