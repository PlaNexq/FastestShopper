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

    //Function to test Lists
    public void Check()
    {
        if (ShoppingList.IsEqual())
        {
            Debug.Log("TRUE");
        }
        else
        {
            Debug.Log("FALSE");
        }
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
        if (ShoppingList.IsEqual())
        {
            Debug.Log("You Win");
        }
        else
        {
            Debug.Log("You Lose");
        }
    }
       
    public void Buy(string productName)
    {

        //If product is in shopping list, then we change color of that item to green
        if (ShoppingList.GetShoppingList().Contains(productName))
        {
            Color green = new Color32(65, 178, 65, 255);
            TxtFileSettings.ChangeColorText(green, productName);
        }

        ShoppingList.AddElementToCartList(productName);
        //Debug.Log("Product: " + productName + " was added to cart list");
    }

    public void DeleteProduct(string productName)
    {
        
        if (ShoppingList.GetShoppingList().Contains(productName))
        {
            Color red = new Color32(186, 0, 0, 255);
            TxtFileSettings.ChangeColorText(red, productName);
        }
        ShoppingList.DeleteElementFromCartList(productName);
        //Debug.Log("Product: " + productName + " was deleted from cart list");
    }

    

    public void Dialogue()
    {
        Debug.Log("What are you doing???");
    }

    bool isEnd = false;
    private void Update()
    {
        if (!isEnd)
        {
            if (Timer.Instance.CurrentTime <= 0)
            {
                isEnd = true;
                EndGame();

            }
        }
    }
}
