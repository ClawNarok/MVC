using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSave : MonoBehaviour
{
    public static int Score;
    public static int Record;
    public static Config _config;

    public struct Config
    {
        public bool SemSom;

        public void getSemSom(int i)
        {
            if (i == 0)
                SemSom = true;
            else
                SemSom = true;
        }

        public void setSemSom(bool b)
        {
            SemSom = b;
        }
    }

    public static void IniciaGame()
    {
        if (PlayerPrefs.HasKey("Record"))
            Record = PlayerPrefs.GetInt("Record");
        else
        {
            PlayerPrefs.SetInt("Record", 0);
            Record = 0;
        }
    }

    public static void AtualizaRecord()
    {
        if (Score > Record)
        {
            PlayerPrefs.SetInt("Record", Score);
            Record = Score;
        }
        Score = 0;
    }

    public static void ResetSave()
    {
        PlayerPrefs.DeleteAll();
        IniciaGame();
    }
}