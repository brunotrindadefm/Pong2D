using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public bool isGoalPlayer1;

    // Método para quando a bola bater em algum dos gols
    void OnTriggerEnter2D(Collider2D other)
    {
        // Se for o gol do player 1, player 2 ganha um ponto
        if (isGoalPlayer1)
        {
            FindObjectOfType<GameManager>().IncreasePlayer2Points();
        }
        // Ao contrário, player 1 ganha um ponto
        else
        {
            FindObjectOfType<GameManager>().IncreasePlayer1Points();
        }

        BallControl ballControl = other.GetComponent<BallControl>();
        if (ballControl)
        {
            ballControl.ResetBall();
        }

    }

}
