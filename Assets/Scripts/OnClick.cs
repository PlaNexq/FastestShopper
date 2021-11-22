using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CallStartGame()
    {
        GameManager.Instance.StartGame();
    }

    public void CallLoadNextLevel()
    {
        GameManager.Instance.LoadNextLevel();
    }

    public void CallToMainMenu()
    {
        GameManager.Instance.LoadMainMenu();
    }

    public void CallExit()
    {
        GameManager.Instance.GameQuit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
