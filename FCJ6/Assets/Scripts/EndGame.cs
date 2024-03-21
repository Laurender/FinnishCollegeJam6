using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject endPanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        } else if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(2);
        } else if (Input.GetKeyDown(KeyCode.M))
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            SceneManager.LoadScene(0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            endPanel.SetActive(true);
            //turn player off
            collision.gameObject.GetComponent<PlayerMovement>().StopPlaying();
        }
    }

    public void OnMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
