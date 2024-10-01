using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int player1Points;
    public int player2Points;
    public TextMeshProUGUI pointText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Método para aumentar pontos do player 1
    public void IncreasePlayer1Points()
    {
        player1Points += 1;
        UpdatePointText();
    }

    // Método para aumentar pontos do player 2
    public void IncreasePlayer2Points()
    {
        player2Points += 1;
        UpdatePointText();
    }

    // Método para atualizar pontuação, que está na interface do usuário
    public void UpdatePointText()
    {
        // Acessa o text do text e reescreve com as váriaveis de pontos dos players
        pointText.text = player1Points + "  X  " + player2Points;
    }
}
