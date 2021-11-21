using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TxtFileSettings : MonoBehaviour
{
    
    //Number of item that will be enabled
    [SerializeField]
    private int m_itemCount = 0;

    private TextMeshProUGUI[] m_components;

    private Vector2 startPosition;

    public int ItemCount {
        get
        {
            return m_itemCount;
        }
    }

    private void Awake()
    {
        Transform ItemsChild = gameObject.transform.Find("TxtMain");
        m_components = ItemsChild.GetComponentsInChildren<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition;
        Debug.Log(transform.localPosition);
        float width = ((RectTransform)transform).rect.width;
        float height = ((RectTransform)transform).rect.height;
        GetComponentInChildren<GridLayoutGroup>().cellSize = new Vector2((width - 2), ((height - 11) / m_itemCount));
        ShoppingList.Initialize(m_itemCount);

        for (int i = 0; i < m_itemCount; i++)
        {
            m_components[i].text = ShoppingList.GetElementValue(i);

            m_components[i].enabled = true;
        }
        for (int i = m_itemCount; i < m_components.Length; i++)
        {
            m_components[i].enabled = false;
        }

        //gameObject.SetActive(false);
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
