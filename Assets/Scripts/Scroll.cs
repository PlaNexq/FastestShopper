using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField]
    private float m_scrollSensetivity = 3f;
    [SerializeField]
    private Scrollbar m_scrollBar = null;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var mouseScrollDelta = Input.mouseScrollDelta.y;
        m_scrollBar.value += mouseScrollDelta * Time.deltaTime * m_scrollSensetivity;

    }

}
