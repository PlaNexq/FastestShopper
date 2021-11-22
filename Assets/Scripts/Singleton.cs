using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inherit to create a single, global-accessible instance of a class
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T m_instance = null;

    public static T Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = GameObject.FindObjectOfType<T>();
                if (m_instance == null)
                {
                    var singletonObj = new GameObject();
                    singletonObj.name = typeof(T).ToString();
                    m_instance = singletonObj.AddComponent<T>();
                }
            }
            return m_instance;
        }
    }

    internal virtual void Awake()
    {
        
        if (m_instance != null)
        {
            Destroy(gameObject);
            return;
        }

        m_instance = GetComponent<T>();
        Debug.Log("Created " + typeof(T).ToString());

        DontDestroyOnLoad(gameObject);

        if (m_instance == null)
            return;
    }
}