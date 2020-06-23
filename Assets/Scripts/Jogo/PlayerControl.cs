using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject player;
    public float maxHeight;
    public float minHeight;

    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        float tr = Input.GetAxis("Vertical") * speed;

        player.transform.Translate(0, tr, 0);

        if (player.transform.position.y > maxHeight)
        {
            player.transform.position = new Vector2(-6f, maxHeight);
        }

        if (player.transform.position.y < minHeight)
        {
            player.transform.position = new Vector2(-6f, minHeight);
        }
    }
}
