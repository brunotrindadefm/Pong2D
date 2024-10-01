using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int player1Points;
    public int player2Points;
    public TextMeshProUGUI pointText;
    public AudioSource goalSound;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;

        player1Points = 0;
        player2Points = 0;
        pointText.text = player1Points + "  X  " + player2Points;
    }

    // Update is called once per frame
    void Update()
    {   
        // Se o usuário apertar R, reiniciará o jogo
        if(Input.GetKeyDown(KeyCode.R))
        {
            GameReset();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            EndGame();
        }
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

        // Efeito de som de gol toda vez q sai um gol
        goalSound.Play();
    }

    // Método para reiniciar o jogo
    private void GameReset()
    {
        // Carregando uma cena com o loadscene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void EndGame()
    {
        Application.Quit();
    }
}
