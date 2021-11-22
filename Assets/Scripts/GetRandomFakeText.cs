using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class GetRandomFakeText : MonoBehaviour
{
    [SerializeField]
    Sprite[] m_fakeTextSprites;
    [SerializeField]
    Image m_image;

    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(0, m_fakeTextSprites.Length - 1);
        m_image.sprite = m_fakeTextSprites[randomNumber];
    }

}
