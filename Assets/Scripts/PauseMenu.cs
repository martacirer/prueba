using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;

    public static bool GameIsPaused = false;

    // Update is called once per frame
    void Update()
    {
        //active panel when click the ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                //if is paused, resume the game
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
   public void Resume()
    {
        PauseMenuUI.SetActive(false);//hide panel
        Time.timeScale = 1f;//resume time
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;//hide the mouse
    }
    
    public void Pause()
    {
        PauseMenuUI.SetActive(true);//hide panel
        Time.timeScale = 0f;///resume time
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;//hide the mouse 
    }
}
