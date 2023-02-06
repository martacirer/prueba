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
        //Si pulsamos la tecla Esc se activa el panel de Pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                //Si ya esta pausado, se reanuda el juego
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
        PauseMenuUI.SetActive(false);//Se oculta el panel
        Time.timeScale = 1f;//Se reanuda el tiempo
        GameIsPaused = false;//Variable booleana igual a false
        Cursor.lockState = CursorLockMode.Locked;//Se oculta el raton
    }
    
    void Pause()
    {
        PauseMenuUI.SetActive(true);//Se muestra el panel
        Time.timeScale = 0f;//Se para el tiempo
        GameIsPaused = true;//Variable booleana igual a true
        Cursor.lockState = CursorLockMode.None;//Se muestra el raton 
    }
}
