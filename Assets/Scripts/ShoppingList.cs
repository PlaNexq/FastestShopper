using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShoppingList
{

    static private List<string> m_ListOfProducts = new List<string>{ "Grand Dad", "Mario", "Win98 NES",
            "Panda Prince", "Konkey Dong", "Sonic the Hedgehog", "Blue Hedgehog",
            "Hungry Birds", "Wario", "Donkey Kong", "Godzilla Lamp (Only Blue)",
            "Unicorn Headphones", "Crocodile Watch", "Cap with Flashlight (Blue)",
            "Otamatone", "4-USB Charger", "Cap with Flashlight (Pink)",
            "Godzilla Lamp (Only Pink)", "Nano Gauntlet", "Unicorn Headphones (GOLD EDITION)",
            "Jam \"One Minute\"", "Smiley Cactus", "Gorilla Pillow", "Pasta Machine",
            "Pickle Morty", "Pickle Rick", "Cat Shorts", "Floppa Pillow",
            "SCP-173 Kigurumi", "Yo-Yo"
    };

    //List of all products that you CAN buy
    static private List<string> m_TempListOfProducts = null;


    //List of products that you NEED to buy
    static private List<string> m_shoppingList = new List<string>();

    //List of products that are in your cart
    static private List<string> m_cartList = new List<string>();

    static public void Initialize(int numberOfItems)
    {
        m_TempListOfProducts = new List<string>(m_ListOfProducts);

        for (int i = 0; i < numberOfItems; ++i)
        {
            int randomNumber = UnityEngine.Random.Range(0, m_TempListOfProducts.Count - 1);
            m_shoppingList.Add(m_TempListOfProducts[randomNumber]);
            m_TempListOfProducts.RemoveAt(randomNumber);

            //Debug.Log("Item added: " + m_shoppingList[i]);

        }
    }

    static public void AddElementToCartList(string productName)
    {
        if (!m_cartList.Contains(productName))
        {
            m_cartList.Add(productName);
        }
    }

    static public void DeleteElementFromCartList(string productName)
    {
        m_cartList.Remove(productName);
    }

    static public string GetElementValue(int index)
    {

        return m_shoppingList[index];

    }

    static public List<string> GetCartList()
    {
        return m_cartList;
    }

    static public List<string> GetShoppingList()
    {
        return m_shoppingList;
    }

    static public bool IsEqual()
    {
        if(m_cartList.Count != m_shoppingList.Count)
        {
            return false;
        }
            m_cartList.Sort();
            m_shoppingList.Sort();
        for (int i = 0; i < m_cartList.Count; ++i)
        {
            if (m_cartList[i] != m_shoppingList[i])
            {
                return false;
            }
        }
        return true;

    }

}
