using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public event Action GameStarted, GameEnded;

    [SerializeField]
    private float m_penalty = 3f;
    [SerializeField]
    private int m_shoppingListItemsNumber = 8;


    private void Start()
    {
        StartMainMenu();
    }

    public void StartMainMenu()
    {
        AudioManager.Instance.Play("MainMenuMusic");
    }
    

    public void StartGame()
    {
        LoadNextLevel();
        InitShoppingList();
        Timer.Instance.ResetTimer();
        GameStarted += Timer.Instance.StartTimer;
        ShoppingList.GetCartList().Clear();
        GameStarted?.Invoke();
        AudioManager.Instance.Stop("MainMenuMusic");
        AudioManager.Instance.Play("GameMainMusic");
    }
    public void EndGame()
    {
        //GameEnded?.Invoke();
        Timer.Instance.StopTimer();
        if (ShoppingList.IsEqual())
        {
            AudioManager.Instance.Play("WinSound");
            LoadLevel("Win");
        }
        else
        {
            AudioManager.Instance.Restart("GameMainMusic");
            LoadLevel("Lose");
        }
    }
       

    public int GetShoppingListNumber()
    {
        return m_shoppingListItemsNumber;
    }

    public void InitShoppingList()
    {
        ShoppingList.GetShoppingList().Clear();
        ShoppingList.Initialize(m_shoppingListItemsNumber);
    }

    public void Buy(string productName)
    {

        //If product is in shopping list, then we change color of that item to green
        if (ShoppingList.GetShoppingList().Contains(productName) && !ShoppingList.GetCartList().Contains(productName))
        {
            Color green = new Color32(65, 178, 65, 255);
            TxtFileSettings.ChangeColorText(green, productName);
            ShoppingList.AddElementToCartList(productName);
            AudioManager.Instance.Play("BuySound");
        }
        else
        {
            Timer.Instance.SetTime(Timer.Instance.CurrentTime - m_penalty);
            AudioManager.Instance.Play("WrongSound");
        }
        if (ShoppingList.IsEqual())
        {
            EndGame();
        }

        //Debug.Log("Product: " + productName + " was added to cart list");
    }

    /*
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
    */
    

    public void Dialogue()
    {
        AudioManager.Instance.Play("WrongSound");
    }

    public void LoadMainMenu()
    {
        ShoppingList.GetShoppingList().Clear();
        AudioManager.Instance.Stop("GameMainMusic");
        AudioManager.Instance.Play("MainMenuMusic");
        LoadLevel("MainMenu");
    }

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadPreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void GameQuit()
    {
        Application.Quit();
        Debug.Log("YOU QUIT FROM GAME");
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
