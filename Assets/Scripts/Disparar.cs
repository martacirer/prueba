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
        // component Audio Source
        Audio = GetComponent<AudioSource>();
        PauseMenuScript = FindObjectOfType<PauseMenu>(); // find script
    }

    void Update()
    {
        if (PauseMenu.GameIsPaused == false) 
        {
            //left click
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(projectilePrefab, transform.position, transform.rotation); //instance bullet in a determinate position
                Audio.PlayOneShot(shootClip, 1); //play the audio when you shot

            }
        }
    }
}
