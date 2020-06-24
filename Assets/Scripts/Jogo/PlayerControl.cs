using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    GamePlay GP;
    public GameObject player;
    public GameObject gameOverPrefab;
    public float maxHeight;
    public float minHeight;
    public float speedY;
    public float speedX;
    public GameObject Inimigos;

    void Awake()
    {
        Inimigos = new GameObject("Inimigos");
        Inimigos.transform.SetParent(GP.transform);
    }

    void Update()
    {
        float trY = Input.GetAxis("Vertical") * speedY;
        float trX = Input.GetAxis("Horizontal") * speedX;

        player.transform.Translate(trX, trY, 0);

        var pos = player.transform.position;

        if (player.transform.position.y > maxHeight)
            player.transform.position = new Vector2(pos.x, maxHeight);

        if (player.transform.position.y < minHeight)
            player.transform.position = new Vector2(pos.x, minHeight);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        var gameOver = Instantiate(gameOverPrefab, Camera.main.transform.position, Quaternion.identity);
        Destroy(gameOver, gameOver.GetComponent<AudioSource>().clip.length);
        Destroy(Inimigos);
        GP.GameOver();
    }

    public void Pontuar()
    {
        GP.UpdateScore();
    }
}