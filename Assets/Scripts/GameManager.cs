using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public enum GameState
    {
        None,
        SplashScreen,
        MainMenuScreen,
        GameNavigationScreen,
        SettingsScreen,
        CreditsScreen,
        GameStartScreen,
        GamePlayingScreen,
        GamePausedScreen,
        GameWonScreen,
        GameLostScreen
    }

    private GameState _currentState = GameState.None;
    private MenuScreen _previousMenuScreen;
    public MenuScreen CurrentMenuScreen;
    public AudioSource SoundSource;

    public GameState CurrentState
    {
        get { return _currentState; }
    }

	// Use this for initialization
	void Start()
	{
		ShowMenu(CurrentMenuScreen);
    }
	
	public void ShowMenu(MenuScreen menuScreen)
    {
	    if ((SoundSource != null) && (_currentState != GameState.None) && (_currentState != GameState.SplashScreen))
	    {
	        SoundSource.Play();
	    }

	    if (CurrentMenuScreen != null)
	    {
	        _previousMenuScreen = CurrentMenuScreen;
	        _previousMenuScreen.IsOpen = false;
	    }

	    CurrentMenuScreen = menuScreen;
	    CurrentMenuScreen.IsOpen = true;

	    _currentState = menuScreen.State;
    }

    public void ShowPreviousMenu()
    {
        if (_previousMenuScreen != null)
        {
            ShowMenu(_previousMenuScreen);
        }
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
