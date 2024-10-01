using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed;
    public bool isPlayer1;
    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            MovePlayer1();
        }
        else
        {
            MovePlayer2();
        }

    }

    // Método para mover o jogador 1
    private void MovePlayer1()
    {
        // Limitando ao retângulo não ultrapassar o tamanho da tela
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        // Se o jogador apertar a tecla W
        if (Input.GetKey(KeyCode.W))
        {
            // Move o retângulo para cima
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        // Se o jogador apertar a tecla S
        if (Input.GetKey(KeyCode.S))
        {
            // Move o retângulo para cima
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }

    // Método para mover o jogador 2
    private void MovePlayer2()
    {
        // Limitando ao retângulo não ultrapassar o tamanho da tela
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax));

        // Se o jogador apertar a seta para cima
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        // Se o jogador apertar a seta para baixo
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Move o retângulo para baixo
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}