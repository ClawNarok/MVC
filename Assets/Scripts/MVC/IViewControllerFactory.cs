using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IViewControllerFactory
{
    MainMenuViewController CreateMainMenuViewController();
    SettingsMenuViewController CreateSettingsMenuViewController();
    GamePlayViewController CreateGamePlayViewController();
}