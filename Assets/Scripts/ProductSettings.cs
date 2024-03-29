using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode]
public class ProductSettings : MonoBehaviour
{
    [SerializeField]
    private float m_stars;
    [SerializeField]
    private int m_numOfStars;

    [SerializeField]
    private Sprite m_ImageSprite;

    [SerializeField]
    private string m_text;

    private Image[] m_starsImages;
    [SerializeField]
    private Sprite m_fullStar;
    [SerializeField]
    private Sprite m_halfStar;
    [SerializeField]
    private Sprite m_emptyStar;

    private GameObject buyButton;


    private void Start()
    {
        //Get reference on text and product sprite
        transform.GetComponentInChildren<TextMeshProUGUI>().text = m_text;
        transform.Find("ProductImage").GetComponent<Image>().sprite = m_ImageSprite;
        m_starsImages = transform.Find("Stars").GetComponentsInChildren<Image>();

        //Get reference on buttons
        buyButton = transform.Find("BuyButton").gameObject;

        //loop for right number of heart output
        for (int i = 0; i < m_numOfStars; ++i)
        {
            m_starsImages[i].enabled = true;
            if (i == m_stars - 0.5 && m_stars - (int)(m_stars) == 0.5)
            {
                m_starsImages[i].sprite = m_halfStar;
            }
            else if (i < m_stars)
            {
                m_starsImages[i].sprite = m_fullStar;
            }
            else
            {
                m_starsImages[i].sprite = m_emptyStar;
            }
        }

        for (int i = m_numOfStars; i < m_starsImages.Length; ++i)
        {
            m_starsImages[i].enabled = false;
        }
    }

    public void CallBuy()
    {
        GameManager.Instance.Buy(m_text);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
