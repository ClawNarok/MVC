using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroBehavior : MonoBehaviour
{
    public float speed;
    public GameObject carro;
    private PlayerControl player;
    private bool passou;
    private SpawnObject spawn;


    void Start()
    {
        player = FindObjectOfType<PlayerControl>();
        spawn = FindObjectOfType<SpawnObject>();
    }

    void OnEnable()
    {
        passou = false;
    }

    void Update()
    {
        if (AutoSave.Score >= 50)
        {
            speed = -25;
            spawn.rateSpawn = 0.5f;
        }
        else if (AutoSave.Score >= 30)
        {
            speed = -20;
            spawn.rateSpawn = 0.8f;
        }
        else if(AutoSave.Score >= 20)
        {
            speed = -15;
            spawn.rateSpawn = 1f;
        }
        else if(AutoSave.Score >= 10)
        {
            speed = -12;
            spawn.rateSpawn = 1.2f;
        }

        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;

        if (transform.position.x < player.transform.position.x && !passou)
        {
            player.Pontuar();
            passou = true;
            GetComponent<AudioSource>().Play();

            Debug.Log(AutoSave.Score);
        }

        if(transform.position.x < -16)
        {
            Destroy(gameObject);
        }
    }
}