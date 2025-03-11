using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTableScript : MonoBehaviour
{
    public void OnTriggerExit(Collider other)
    {
        {
            if (other.CompareTag("apple")) 
            {
                Debug.Log("apple destroyed!");
                Destroy(other.gameObject);
            }

            if (other.CompareTag("banana"))
            {
                Debug.Log("banana destroyed!");
            }

            if (other.CompareTag("diamond"))
            {
                Debug.Log("diamond destroyed, oh no!!!");
            }
        }
    }
}
