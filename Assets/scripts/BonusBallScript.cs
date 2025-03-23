
using UnityEngine;
public class BonusBallScript : MonoBehaviour
{
    [SerializeField] private GameObject bonusBall;
    [SerializeField] private Transform bonusSpawnPos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("main ball"))
        {
            Instantiate(bonusBall).transform.position = bonusSpawnPos.position;
        }
    }
}