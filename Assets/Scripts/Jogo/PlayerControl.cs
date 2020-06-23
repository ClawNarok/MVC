using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject player;
    public float maxHeight;
    public float minHeight;

    public float speedY;
    public float speedX;

    void Start()
    {
        
    }

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
}
