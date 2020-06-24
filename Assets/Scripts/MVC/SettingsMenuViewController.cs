using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenuViewController : ViewController<SettingsMenuView>
{
    SceneWireframe _wireframe;
    IViewControllerFactory _factory;


    public SettingsMenuViewController(SettingsMenuView view, SceneWireframe wireframe, IViewControllerFactory factory) : base(view)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public void Setup()
    {
        View.Setup(BackToMenu, "Configurações", "Voltar");
        View.AddButton(ClearSave, "Apagar recorde");
    }

    void BackToMenu()
    {
        MainMenuViewController mainMenuViewController = _factory.CreateMainMenuViewController();
        mainMenuViewController.Setup();

        _wireframe.PresentViewController(mainMenuViewController);
    }

    void ClearSave()
    {
        AutoSave.ResetSave();
    }
}