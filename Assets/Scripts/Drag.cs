using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    Vector2 currentMousePosition, lastMousePosition = Vector2.zero;

    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = new Vector2(transform.position.x, transform.position.y) - currentMousePosition;
    }
    private void OnMouseDrag()
    {
        currentMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //currentMousePosition = new Vector2(Mathf.Clamp(currentMousePosition.x, -Camera.main.pixelWidth / 2, Camera.main.pixelWidth / 2), Mathf.Clamp(currentMousePosition.y, -Camera.main.pixelHeight / 2, Camera.main.pixelHeight / 2));
        transform.position = currentMousePosition + offset;
        lastMousePosition = currentMousePosition;
    }
}
