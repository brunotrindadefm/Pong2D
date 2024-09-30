using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float speed;
    public float speedIncreaseFactor = 0.1f;
    public float randomDirectionX;
    public float randomDirectiony;
    public Rigidbody2D rig;
    public AudioSource ballSound;

    // Start is called before the first frame update
    void Start()
    {
        BallMove();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Método para mover a bola
    private void BallMove()
    {
        // Direção inical aleatória
        float randomX = Random.Range(0,2) == 0 ? -1 : 1;
        float randomY = Random.Range(0,2) == 0 ? -1 : 1;

        // Aplica a velocidade inicial em uma posição aleátoria
        rig.velocity = new Vector2(randomX, randomY).normalized * speed;
    }

    // Método que irá ser chamado toda vez que tiver uma colisão da bola
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Tocar o som toda vez que a bola colidir
        ballSound.Play();

        // A bola irá um pouco para o lado sempre que colidir em algo
        rig.velocity += new Vector2(randomDirectionX, randomDirectiony);

        // Aumentando a velocidade a cada colisão
        speed += speedIncreaseFactor;

        // Matendo a direção, mas aumentando a velocidade
        Vector2 currentVelocity = rig.velocity.normalized; // Obtém a direção atual
        rig.velocity = currentVelocity * speed; // Aplia a nova velocidade
    }
}