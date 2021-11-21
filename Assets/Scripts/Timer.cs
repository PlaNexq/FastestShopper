using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : Singleton<Timer>
{
    private float m_currentTime = 60f;
    private bool m_timerIsEnabled = false;
    private TextMeshProUGUI m_timerUI = null;


    /// <summary>
    /// The interval in seconds since starting the timer
    /// </summary> 
    public float CurrentTime
    {
        get
        {
            return m_currentTime;
        }
    }

    internal override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        GameManager.Instance.GameEnded += StopTimer;
        //m_timerUI = GameObject.Find("TimerUI").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (m_timerIsEnabled)
        {
            m_currentTime -= Time.deltaTime;
            m_timerUI.text = m_currentTime.ToString("0");
        }
    }

    /// <summary>
    /// Call to start global timer
    /// </summary>
    public void StartTimer()
    {
        m_timerIsEnabled = true;
    }

    /// <summary>
    /// Call to stop global timer
    /// </summary>
    public void StopTimer()
    {
        m_timerIsEnabled = false;
    }

    /// <summary>
    /// Call to reset global timer
    /// </summary>
    public void ResetTimer()
    {
        m_currentTime = 60f;
    }
}
