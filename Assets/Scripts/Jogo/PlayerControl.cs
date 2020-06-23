using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public GameObject player;
    public float maxHeight;
    public float minHeight;
    public float speedY;
    public float speedX;
    public int Score;


    void Update()
    {
        float trY = Input.GetAxis("Vertical") * speedY;
        float trX = Input.GetAxis("Horizontal") * speedX;

        player.transform.Translate(trX, trY, 0);

        var pos = player.transform.position;

        if (player.transform.position.y > maxHeight)
        {
            player.transform.position = new Vector2(pos.x, maxHeight);
        }

        if (player.transform.position.y < minHeight)
        {
            player.transform.position = new Vector2(pos.x, minHeight);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (Score > PlayerPrefs.GetInt("Recorde"))
        {
            PlayerPrefs.SetInt("Recorde", Score);
        }

        PlayerPrefs.SetInt("Score", Score);

        SceneManager.LoadScene("GameOver");
    }

    public void addscore()
    {
        Score++;
    }
}