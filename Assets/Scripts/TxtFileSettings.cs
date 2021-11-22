using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class TxtFileSettings : MonoBehaviour
{
    
    //Number of item that will be enabled
    [SerializeField]
    private int m_itemCount = GameManager.Instance.GetShoppingListNumber();

    static private TextMeshProUGUI[] m_components;

    private Vector2 startPosition;


    private void Awake()
    {
        Transform ItemsChild = gameObject.transform.Find("TxtMain").Find("Items");
        m_components = ItemsChild.GetComponentsInChildren<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {

        startPosition = transform.localPosition;
        float width = ((RectTransform)transform).rect.width;
        float height = ((RectTransform)transform).rect.height;
        GetComponentInChildren<GridLayoutGroup>().cellSize = new Vector2((width - 2), ((height - 11) / m_itemCount));


        for (int i = 0; i < m_itemCount; i++)
        {
            m_components[i].text = ShoppingList.GetElementValue(i);

            m_components[i].enabled = true;
        }
        for (int i = m_itemCount; i < m_components.Length; i++)
        {
            m_components[i].enabled = false;
        }
    }

    static public void ChangeColorText(Color color, string productName)
    {
        for (int i = 0; i < m_components.Length; ++i)
        {
            if (m_components[i].text == productName)
            {
                m_components[i].color = color;
            }
        } 
    }

    public void OpenWindow()
    {
        transform.localPosition = startPosition;
        gameObject.SetActive(true);
    }

    public void CloseWindow()
    {
        gameObject.SetActive(false);
    }
}
