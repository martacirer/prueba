using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlow : MonoBehaviour
{
    public void GoToMainScene(string name)
    {
        //Carga la escena principal
        SceneManager.LoadScene("Main Menu");
    }

     public void GoToOptionsMenu(string name)
    {
        //Carga la escena principal
        SceneManager.LoadScene("options");
    }

      public void GoToCreditssMenu(string name)
    {
        //Carga la escena principal
        SceneManager.LoadScene("credits");
    }

      public void GoToHowToPlayMenu(string name)
    {
        //Carga la escena principal
        SceneManager.LoadScene("HowToPlay");
    }

      public void GoToLevelsMenu(string name)
    {
        //Carga la escena principal
        SceneManager.LoadScene("Levels");
    }

      public void GoToGame(string name)
    {
        //Carga la escena principal
        SceneManager.LoadScene("juego");
    }
}
