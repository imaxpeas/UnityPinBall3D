using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDeliveryScript : MonoBehaviour
{
    private int WaterLiters;
    private int RewardPrecent;
    

    private void start()
    {
        if (WaterLiters < 20000)
        {
            Debug.Log("plan not completed");
        }
        else if (WaterLiters == 20000) 
        {
            RewardPrecent = RewardPrecent + 10;
        }
        if (WaterLiters == 30000)
        {
            RewardPrecent = RewardPrecent + 30;
        }
    }   
}