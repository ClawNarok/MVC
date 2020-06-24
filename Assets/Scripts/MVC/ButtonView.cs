using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonView : MonoBehaviour
{
    Action _buttonCallback;
    [SerializeField]
    Text _txtButton;

    
    public void Setup(Action buttonCallback, string txtButton)
    {
        _buttonCallback = buttonCallback;
        _txtButton.text = txtButton;
    }

    public void OnClick()
    {
        if (_buttonCallback != null)
            _buttonCallback.Invoke();
    }
}