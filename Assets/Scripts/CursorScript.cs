using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    [SerializeField]
    Sprite cursorIdle, cursorWrong, cursorPointing;
    Vector2 m_offset;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition - new Vector2(-0.25f, 0.25f);
    }

    private void LoadSprites()
    {

        cursorIdle = Resources.Load<Sprite>("Sprites/cursor_Idle");
        cursorWrong = Resources.Load<Sprite>("Sprites/cursor_Wrong");
        cursorPointing = Resources.Load<Sprite>("Sprites/cursor_Pointing");
    }

}
