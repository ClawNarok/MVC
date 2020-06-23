using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectorViewControllerFactory : MonoBehaviour, IViewControllerFactory
{
    [SerializeField]
    SceneWireframe _wireframe;
    [SerializeField]
    MainMenuView _mainMenuViewPrefab;

    public MainMenuViewController CreateMainMenuViewController()
    {
        MainMenuView mainMenuView = Instantiate(_mainMenuViewPrefab);
        return new MainMenuViewController(mainMenuView, _wireframe, this);
    }
}