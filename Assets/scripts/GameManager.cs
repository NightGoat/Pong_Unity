using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public Text playerScoreText;
    public Text computerScoreText;

    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    public void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
    }
}
