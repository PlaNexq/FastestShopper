using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShoppingList
{
    static private Dictionary<string, bool> shoppingList = new Dictionary<string, bool>();
    public void Initialize()
    {
        shoppingList.Add("Grand Dad", false);
    }
    public bool GetStatusOfItem(string item)
    {
        if (!shoppingList.ContainsKey(item))
        {
            
        }
        return true;

    }
}
