using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    Action _endGameCallBack;
    Action<int> _scoreUpdateCallback;

    public void Setup(Action endGameCallBack, Action<int> scoreUpdateCallback)
    {
        _endGameCallBack = endGameCallBack;
        _scoreUpdateCallback = scoreUpdateCallback;
    }

    public void GameOver()
    {
        AutoSave.AtualizaRecord();
        if (_endGameCallBack != null)
            _endGameCallBack.Invoke();
    }

    public void UpdateScore()
    {
        Score.Pontuar();
        if (_scoreUpdateCallback != null)
            _scoreUpdateCallback.Invoke(AutoSave.Score);
    }
}