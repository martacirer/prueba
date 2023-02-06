
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public int Score = 0;

    public static GameManager sharedInstance;
  

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
 
    public void contador(int p)
    {
        Score+= p; // suma 1
        pointText.text = $"Score: {Score}";// puntuación
    }



}
