using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuertePlayer : MonoBehaviour
{

    public Barra_Vida BV;

    // Start is called before the first frame update
    void Start()
    {
        BV = GetComponent<Barra_Vida>();

    }

    // Update is called once per frame
    void Update()
    {
        if(BV.vidaActual <= 0f)
        {
            SceneManager.LoadScene("LoseLevel");
        }
    }
}
