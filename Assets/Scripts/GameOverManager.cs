
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public static GameOverManager sharedInstance;
    public TextMeshProUGUI username;

    private void Awake()
    {

        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            //Si ya existe una instancia, se destruye
            Destroy(this);
        }
    }

    
   
    

}
