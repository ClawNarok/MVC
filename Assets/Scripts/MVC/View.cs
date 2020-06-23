using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public Action OnDestroyCallback { get; set; }

    void OnDestroy()
    {
        if (OnDestroyCallback != null)
            OnDestroyCallback.Invoke();
    }
}