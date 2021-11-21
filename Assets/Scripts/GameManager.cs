using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public event Action GameStarted, GameEnded;

    private ShoppingList shoppingList = new ShoppingList();

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        GameStarted += Timer.Instance.StartTimer;
        GameStarted?.Invoke();
        shoppingList.Initialize();
    }

    public void EndGame()
    {
        GameEnded?.Invoke();
    }

    public void Buy()
    {

    }

    public void Dialogue()
    {
        Debug.Log("What are you doing???");
    }

    private void Update()
    {
        if (Timer.Instance.CurrentTime <= 0)
        {
            EndGame();
        }
    }
}
