using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField]
    Text _txtTitle;

    public void Setup(string txt)
    {
        _txtTitle.text = txt;
    }
}