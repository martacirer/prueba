using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFlow : MonoBehaviour
{
    public string PlayerName;

    void Update()
    {
        
    }
    public void GoToMainScene(string name)
    {
        //Carga la escena principal
        SceneManager.LoadScene("Main Menu");
    }

     public void GoToOptionsMenu(string name)
    {
        //Carga la escena opciones
        SceneManager.LoadScene("options");
    }

      public void GoToCreditssMenu(string name)
    {
        //Carga la escena creditos
        SceneManager.LoadScene("credits");
    }

      public void GoToHowToPlayMenu(string name)
    {
        //Carga la escena cmom jugar
        SceneManager.LoadScene("HowToPlay");
    }

      public void GoToLevelsMenu(string name)
    {
        //Carga la escena niveles
        SceneManager.LoadScene("Levels");
    }

      public void GoToGame(string name)
    {
        //Carga la escena game
        SceneManager.LoadScene("juego");
    }

    public void RaedStringImput(string s)
    {
        PlayerName = s;
        DataPersistance.PlayerStats.TextUser = PlayerName;
    }
}
