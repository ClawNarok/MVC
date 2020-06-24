using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayViewController : ViewController<GamePlayView>
{
    SceneWireframe _wireframe;
    IViewControllerFactory _factory;

    public GamePlayViewController(GamePlayView view, SceneWireframe wireframe, IViewControllerFactory factory) : base(view)
    {
        _wireframe = wireframe;
        _factory = factory;
    }

    public void Setup(GamePlay gamePlay)
    {
        View.Setup(gamePlay, EndGame);
    }

    void EndGame()
    {
        Game.EndGame();
        MainMenuViewController mainMenuViewController = _factory.CreateMainMenuViewController();
        mainMenuViewController.Setup();

        _wireframe.PresentViewController(mainMenuViewController);
    }
}