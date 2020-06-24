using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuView : View
{
    [SerializeField]
    Text _txtTitle;

    [SerializeField]
    ButtonView _buttonBackView;
    [SerializeField]
    Transform _btnList;
    
    [SerializeField]
    ButtonView _buttonViewPrefab;


    public void Setup(Action buttonCallback, string txtTitle, string btnText)
    {
        _txtTitle.text = txtTitle;
        _buttonBackView.Setup(buttonCallback, btnText);
    }

    public void AddButton(Action buttonCallback, string txtButton)
    {
        ButtonView buttonView = Instantiate(_buttonViewPrefab, _btnList);
        buttonView.Setup(buttonCallback, txtButton);
    }
}