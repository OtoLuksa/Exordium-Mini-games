using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{

    private GameManager _gameManager;
    public Text SplashMessage;
    public MenuScreen NextMenuScreen;

    // Use this for initialization
    void Start ()
    {
        _gameManager = GetComponentInParent<GameManager>();

        #if UNITY_ANDROID
            SplashMessage.text = "Tap to continue";
        #else
            SplashMessage.text = "Press any key or click to continue";
        #endif
    }

    // Update is called once per frame
    void Update ()
    {
        if ((Input.anyKeyDown) && (_gameManager.CurrentState == GameManager.GameState.SplashScreen))
        {
            _gameManager.ShowMenu(NextMenuScreen);
        }
	}
}
