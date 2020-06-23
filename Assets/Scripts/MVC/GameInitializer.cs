using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer
{
    SceneWireframe _wireframe;
    IViewControllerFactory _factory;

    public GameInitializer(SceneWireframe wireframe, IViewControllerFactory factory)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public void Init()
    {
        MainMenuViewController mainMenuViewController = _factory.CreateMainMenuViewController();
        mainMenuViewController.Setup();

        _wireframe.PresentViewController(mainMenuViewController);
    }
}