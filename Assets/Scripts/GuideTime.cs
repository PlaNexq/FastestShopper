using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideTime : MonoBehaviour
{
    [SerializeField]
    private float m_TimeBeforeEnd;
    private bool isEnd = false;
    GameObject loading, button;
    // Start is called before the first frame update
    void Start()
    {
        loading = transform.Find("Loading").gameObject;
        button = transform.Find("NextLevelButton").gameObject;
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_TimeBeforeEnd > 0)
        {
            m_TimeBeforeEnd -= Time.deltaTime;
        }
        else
        {
            if (!isEnd)
            {
                isEnd = true;
                loading.SetActive(false);
                button.SetActive(true);
            }
        }
    }
}
