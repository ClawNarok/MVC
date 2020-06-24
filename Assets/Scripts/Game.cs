using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GamePlay gamePrefab;
    static Game _instance;

    void Awake()
    {
        _instance = this;
    }

    public static GamePlay PlayGame()
    {
        return Instantiate(_instance.gamePrefab);
    }

    public static void EndGame()
    {
        GamePlay gamePlay = FindObjectOfType<GamePlay>();
        GameObject.Destroy(gamePlay.gameObject);
    }
}