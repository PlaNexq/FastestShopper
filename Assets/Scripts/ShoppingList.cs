using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShoppingList
{
    //List of all product that you CAN buy
    static int initializeTimesCount = 0;

    static private List<string> listOfProducts = new List<string>{ "Grand Dad", "Mario", "Win98 NES", 
            "Panda Prince", "Konkey Dong", "Grand Dad", "Sonic the Hedgeghog", 
            "Hungry Birds", "Wario", "Donkey Kong", "Godzilla Lamp (Only Blue)", 
            "Unicorn Headphones", "Crocodile Watch", "Cap with Flashlight (Blue)",
            "Otamatone", "4-USB Charger", "Cap with Flashlight (Pink)",
            "Godzilla Lamp (Only Pink)", "Nano Gauntlet", "Unicorn Headphones (GOLD EDITION)"};

    //List of product that you NEED to buy
    static private string[] m_shoppingList;

    static public void Initialize(int numberOfItems)
    {
        initializeTimesCount++;
        if (initializeTimesCount > 1)
        {
            Debug.LogError(typeof(ShoppingList).Name + " was initialized more than once, check your code!");
        }

        m_shoppingList = new string[numberOfItems];
        for (int i = 0; i < numberOfItems; ++i)
        {
            int randomNumber = UnityEngine.Random.Range(0, listOfProducts.Count - 1);
            m_shoppingList[i] = listOfProducts[randomNumber];
            listOfProducts.RemoveAt(randomNumber);

            Debug.Log("Item added: " + m_shoppingList[i]);

        }
    }

    static public string GetElementValue(int index)
    {

        return m_shoppingList[index];

    }

}
