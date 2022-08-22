using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;

    public static bool Player1Win = false;
    public static bool Player2Win = false;

    public BallControl ballControl;
    public UIManager uiManager;

    private void Update()
    {
        if (Player1Win || Player2Win)
        {
            ballControl.ResetBall();
        }
    }


    public void Score(string wallID)
    {
        if (wallID == "Right wall")
        {
            PlayerScore1++;
            if (PlayerScore1 == 10)
            {
                Player1Win = true;
            }
        }
        else
        {
            PlayerScore2++;
            if (PlayerScore2 == 10)
            {
                Player2Win = true;
            }
        }

        uiManager.UpdateScore();
    }

    public void ResetGame()
    {
        PlayerScore1 = 0;
        PlayerScore2 = 0;

        Player1Win = false;
        Player2Win = false;

        uiManager.ResetUi();
        ballControl.RestartGame();
    }
}