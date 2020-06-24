using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectorViewControllerFactory : MonoBehaviour, IViewControllerFactory
{
    [SerializeField]
    SceneWireframe _wireframe;
    [SerializeField]
    MainMenuView _mainMenuViewPrefab;
    [SerializeField]
    SettingsMenuView _settingsMenuViewPrefab;
    [SerializeField]
    GamePlayView _gamePlayViewPrefab;


    public MainMenuViewController CreateMainMenuViewController()
    {
        MainMenuView mainMenuView = Instantiate(_mainMenuViewPrefab);
        return new MainMenuViewController(mainMenuView, _wireframe, this);
    }

    public SettingsMenuViewController CreateSettingsMenuViewController()
    {
        SettingsMenuView settingsMenuView = Instantiate(_settingsMenuViewPrefab);
        return new SettingsMenuViewController(settingsMenuView, _wireframe, this);
    }

    public GamePlayViewController CreateGamePlayViewController()
    {
        GamePlayView gamePlayView = Instantiate(_gamePlayViewPrefab);
        return new GamePlayViewController(gamePlayView, _wireframe, this);
    }
}