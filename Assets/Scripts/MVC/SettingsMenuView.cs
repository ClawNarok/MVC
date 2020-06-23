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
    ButtonView _buttonView;


    public void Setup(Action buttonCallback, string txtTitle, string btnText)
    {
        _txtTitle.text = txtTitle;
        _buttonView.Setup(buttonCallback, btnText);
    }
}