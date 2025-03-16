using UnityEngine;

public class WaterDeliveryScript : MonoBehaviour
{
    private int WaterLiters = 10000;
    private int RewardPrecent;


    private void Start()
    {
        if (WaterLiters < 20000)
        {
            Debug.Log("plan not completed");
        }
        else if (WaterLiters )
            
        {
            RewardPrecent = RewardPrecent + 10;
        }
        if (WaterLiters == 30000)
        {
            RewardPrecent = RewardPrecent + 30;
        }
    }
}
//19, 20, 25, 30, 31
