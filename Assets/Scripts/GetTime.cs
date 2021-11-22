using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetTime : MonoBehaviour
{
    TextMeshProUGUI timerUI;
    // Start is called before the first frame update
    void Start()
    {
        timerUI = transform.Find("TimerUI").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timerUI.text = Timer.Instance.CurrentTime.ToString("0");
    }
}
