using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode]
public class TabSettings : MonoBehaviour
{
    [SerializeField]
    private Sprite selectedSprite, unselectedSprite;

    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField]
    private bool isSelected = false;

    private static GameObject gameManagerClone;

    // Start is called before the first frame update
    void Start()
    {
        if (isSelected)
        {
            transform.GetComponent<Image>().sprite = selectedSprite;
            text.color = new Color32(255, 255, 255, 255);
        }
        else
        {
            transform.GetComponent<Image>().sprite = unselectedSprite;
            text.color = new Color32(160, 160, 160, 255);
        }
    }

    public void PlayDialogue()
    {
        gameManagerClone = GameObject.Find("GameManager");
        gameManagerClone.GetComponent<GameManager>().Dialogue();
    }
}
