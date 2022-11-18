using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    public GameObject mainView;
    public GameObject settingsView;
    public GameObject playerView;

    private void Start()
    {
        onGoBack();
    }
    public void onStart()
    {
        SceneManager.LoadScene("scenaGry");
    }
    public void onSettings()
    {
        mainView.SetActive(false);
        settingsView.SetActive(true);
        playerView.SetActive(false);
    }
    public void onPlayer()
    {
        mainView.SetActive(false);
        settingsView.SetActive(false);
        playerView.SetActive(true);
    }
    public void onGoBack()
    {
        mainView.SetActive(true);
        settingsView.SetActive(false);
        playerView.SetActive(false);
    }
    public void onExit()
    {
        Application.Quit();
    }


}
