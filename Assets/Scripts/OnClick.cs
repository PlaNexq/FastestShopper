using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CallToMainMenu()
    {
        GameManager.Instance.LoadLevel("MainMenu");
    }

    public void CallExit()
    {
        GameManager.Instance.GameQuit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
