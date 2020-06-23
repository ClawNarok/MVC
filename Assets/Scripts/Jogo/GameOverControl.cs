using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverControl : MonoBehaviour
{
    public TextMesh atual;
    public TextMesh record;


    void Start()
    {
        atual.text = PlayerPrefs.GetInt("Score").ToString();
        record.text = PlayerPrefs.GetInt("Recorde").ToString();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("Jogo");
        }
    }
}