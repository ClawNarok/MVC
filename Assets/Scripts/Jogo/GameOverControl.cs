using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    public TextMesh atual;
    public TextMesh record;


    void Start()
    {
        atual.text = PlayerPrefs.GetInt("Score").ToString();
        atual.text = PlayerPrefs.GetInt("Recorde").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Application.LoadLevel("Jogo");
        }
    }
}
