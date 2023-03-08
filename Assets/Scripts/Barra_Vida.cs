using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Barra_Vida : MonoBehaviour
{
    public int vidaMax;
    public float vidaActual;
    public Image imagenBarraVida;

    // Start is called before the first frame update
    public void Start()
    {
        vidaActual = vidaMax;
    }

    // Update is called once per frame
    public void Update()
    {
        RevisarVida();

        if(vidaActual <= 0f)
        {
            

            gameObject.SetActive(false);
        }

        if(gameObject.CompareTag("Player"))
        {
            if(vidaActual <= 0f)
            {
            SceneManager.LoadScene("LoseLevel");
            }
           
        }
    }

    public void RevisarVida()
    {
        imagenBarraVida.fillAmount = vidaActual / vidaMax;
    }
}
