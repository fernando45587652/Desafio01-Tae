using UnityEngine;
using TMPro; // Para los textos del marcador

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI cpuScoreText;

    private int playerScore = 0;
    private int cpuScore = 0;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
    }

    public void CpuScores()
    {
        cpuScore++;
        cpuScoreText.text = cpuScore.ToString();
    }
}

