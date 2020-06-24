using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayView : View
{
    [SerializeField]
    Text txtScore;
    [SerializeField]
    Text txtRecord;

    public void Setup(GamePlay gamePlay, Action endGameCallback)
    {
        gamePlay.Setup(endGameCallback, UpdateScore);
        txtScore.text = "Pontos: 00";
        UpdateRecord();
    }

    void UpdateScore(int score)
    {
        txtScore.text = String.Concat("Pontos: ", score.ToString("00"));
    }

    void UpdateRecord()
    {
        txtRecord.text = String.Concat("Record: ", AutoSave.Record.ToString("00"));
    }
}