using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public string nextScene;
    public GameObject controlsPanel;
    public GameObject creditsPanel;

    private void Start()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
    public void OnNewGame()
    {
        //change scene
        SceneManager.LoadScene(nextScene);
    }

    public void OnControls()
    {
        //open controls panel
        controlsPanel.SetActive(true);
    }

    public void OnCloseControls()
    {
        //close controls panel
        controlsPanel.SetActive(false);
    }

    public void OnCredits()
    {
        //open Credits panel
        creditsPanel.SetActive(true);
    }

    public void OnCloseCredits()
    {
        //close Credits panel
        creditsPanel.SetActive(false);
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
