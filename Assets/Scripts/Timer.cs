using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : Singleton<Timer>
{
    private float m_currentTime = 60f;
    private bool m_timerIsEnabled = false;

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
    }

    private void Update()
    {
        if (m_timerIsEnabled)
        {
            m_currentTime -= Time.deltaTime;
            if (CurrentTime <= 0)
            {
                GameManager.Instance.EndGame();
            }
        }
    }

    public void SetTime(float newTime)
    {
        m_currentTime = newTime;
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
