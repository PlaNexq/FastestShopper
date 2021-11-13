using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public event Action GameStarted, GameEnded;

    enum TaskList
    {

    }

    private void Start()
    {
        
    }

    public void StartGame()
    {
        Timer.Instance.StartTimer();
        GameStarted?.Invoke();
    }

    public void EndGame()
    {
        GameEnded?.Invoke();
    }

    private void Update()
    {
        
    }
}
