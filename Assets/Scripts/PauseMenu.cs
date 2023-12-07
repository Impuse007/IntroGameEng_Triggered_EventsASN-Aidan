using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GamePaused = false;

    public GameObject pauseMenuUI;
    public GameObject EndScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (EndScreen.activeSelf == false)
            {
                if (GamePaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
            else
            {
                Debug.Log("Quit");
                Quit();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void Quit()
    {
      
        Application.Quit();
        
    }
}
