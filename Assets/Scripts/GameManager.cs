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
        GameStarted += Timer.Instance.StartTimer;
        GameStarted?.Invoke();
        AudioManager.Instance.Play("Main");
    }

    public void EndGame()
    {
        GameEnded?.Invoke();
    }

    public void Buy(string productName)
    {
        Color green = new Color32(65, 178, 65, 255);

        //If product is in shopping list, then we change color of that item to green
        if (ShoppingList.GetShoppingList().Contains(productName))
        {
            TxtFileSettings.ChangeColorText(green, productName);
        }

        ShoppingList.AddElementToCartList(productName);
        Debug.Log("Product: " + productName + " was added to cart list");
    }

    public void DeleteProduct(string productName)
    {
        ShoppingList.DeleteElementFromCartList(productName);
        Debug.Log("Product: " + productName + " was deleted from cart list");
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
