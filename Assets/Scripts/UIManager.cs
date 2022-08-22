using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI player1Score;
    public TextMeshProUGUI player2Score;


    public TextMeshProUGUI player1Win;
    public TextMeshProUGUI player2Win;

    public void UpdateScore()
    {
        player1Score.text = GameManager.PlayerScore1.ToString();
        player2Score.text = GameManager.PlayerScore2.ToString();

        if (GameManager.Player1Win)
        {
            player1Win.enabled = true;
        }

        if (GameManager.Player2Win)
        {
            player1Win.enabled = true;
        }
    }

    public void ResetUi()
    {
        player1Score.text = "0";
        player2Score.text = "0";

        player1Win.enabled = false;
        player2Win.enabled = false;
    }
}