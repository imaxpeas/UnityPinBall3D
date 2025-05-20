using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int GameScore;

    public static int LivesCount = 3;
    [SerializeField] private TMP_Text livesCountText;
    [SerializeField] private TMP_Text scoreText;
    private void Update()
    {
        scoreText.text = $"{GameScore}";
        livesCountText.text = $"{LivesCount}";
    }
}
