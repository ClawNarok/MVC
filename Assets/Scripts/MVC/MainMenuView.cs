using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField]
    Text _txtTitle;

    [SerializeField]
    Transform _btnList;
    
    [SerializeField]
    ButtonView _buttonViewPrefab;


    public void Setup(string txt)
    {
        _txtTitle.text = txt;
        AutoSave.IniciaGame();
    }

    public void AddButton(Action buttonCallback, string txtButton)
    {
        ButtonView buttonView = Instantiate(_buttonViewPrefab, _btnList);
        buttonView.Setup(buttonCallback, txtButton);
    }
}