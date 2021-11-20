using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode]
public class Items : MonoBehaviour
{
    [SerializeField]
    private GameObject[] m_items;
    [SerializeField]
    private int m_itemNumber = 10;


    // Start is called before the first frame update
    void Start()
    {
        RectTransform rectTransform = (RectTransform)transform;
        float width = rectTransform.rect.width;
        float height = rectTransform.rect.height;
        GetComponentInChildren<GridLayoutGroup>().cellSize = new Vector2((width - 2), ((height - 11) / m_items.Length));
        for (int i = 0; i < m_itemNumber; ++i)
        {
            
            m_items[i].GetComponentInChildren<TextMeshProUGUI>().enabled = true;
        }
        for (int i = m_itemNumber; i < m_items.Length; ++i)
        {
            m_items[i].GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        }
    }
}
