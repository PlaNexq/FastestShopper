using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShoppingList
{
    //List of all product that you CAN buy
    static private string[] listOfProducts = { "Grand Dad", "Mario", "Win98 NES", 
            "Panda Prince", "Konkey Dong", "Grand Dad", "Sonic the Hedgeghog", 
            "Hungry Birds", "Wario", "Donkey Kong", "Godzilla Lamp (Only Blue)", 
            "Unicorn Headphones", "Crocodile Watch", "cap with Flashlight (Blue",
            "Otamatone", "4-USB Charger", "Cap with Flashlight (Pink)",
            "Godzilla Lamp (Only Pink)", "Nano Gauntlet", "Unicorn Headphones (GOLD EDITION)"};
    
    //List of product that you NEED to buy
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
