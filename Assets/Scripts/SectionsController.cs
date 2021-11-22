using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SectionsController : MonoBehaviour
{
    GameObject m_currentGameObject, videoGames, forHome, electronics;
    Scrollbar scrollBar;


    // Start is called before the first frame update
    void Start()
    {
        scrollBar = GameObject.Find("Scrollbar Vertical").GetComponent<Scrollbar>();
        m_currentGameObject = GameObject.Find("VideoGamesSection");
        videoGames = m_currentGameObject;
        forHome = GameObject.Find("ForHomeSection");
        electronics = GameObject.Find("ElectronicsSection");
        forHome.SetActive(false);
        electronics.SetActive(false);
    }
    
    public void ChangeToVideoGame()
    {
        m_currentGameObject.SetActive(false);
        m_currentGameObject = videoGames;
        ResetScrollBarValue();
        videoGames.SetActive(true);
    }
    public void ChangeToForHome()
    {
        m_currentGameObject.SetActive(false);
        m_currentGameObject = forHome;
        ResetScrollBarValue();
        forHome.SetActive(true);
    }
    public void ChangeToElectronics()
    {
        m_currentGameObject.SetActive(false);
        m_currentGameObject = electronics;
        ResetScrollBarValue();
        electronics.SetActive(true);
    }
    public void ChangeToFakeSitePage()
    {
        Debug.Log("GOT YA!!!");
    }

    void ResetScrollBarValue()
    {
        scrollBar.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
