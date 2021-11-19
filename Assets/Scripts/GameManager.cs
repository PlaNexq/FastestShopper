using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public event Action GameStarted, GameEnded;

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        GameStarted?.Invoke();
    }

    public void EndGame()
    {
        GameEnded?.Invoke();
    }

    private void Update()
    {
        
        if (Timer.Instance.CurrentTime <= 0)
        {
            EndGame();
        }
    }
}
