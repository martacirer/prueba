using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Disparar : MonoBehaviour
{
    public GameObject projectilePrefab;
    private AudioSource Audio;
    public AudioClip shootClip;

    private PauseMenu PauseMenuScript;

    void Start()
    {
        //Obtenemos la componente Audio Source
        Audio = GetComponent<AudioSource>();
        PauseMenuScript = FindObjectOfType<PauseMenu>(); // encuentra el script
    }

    void Update()
    {
        if (PauseMenu.GameIsPaused == false) 
        {
            //Al pulsar click izquierdo
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(projectilePrefab, transform.position, transform.rotation); //Instanciar proyectil en una posición determinada
                Audio.PlayOneShot(shootClip, 1); //Reproducimos el audio de disparar

            }
        }
    }
}
