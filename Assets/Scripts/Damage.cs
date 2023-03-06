using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{


    public Barra_Vida bvJugador;
    public Barra_Vida bvEnemigo;
    

    public float dañoEnemigo = 10f;
    public float dañoJugador = 15f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter (Collider otherCollider)
    {


        if (otherCollider.gameObject.CompareTag("proyectil"))
        {
            Destroy(otherCollider.gameObject);//Destruye objecto cuando choca
            bvEnemigo.vidaActual -= dañoEnemigo;// baja vida al enemigo
            Debug.Log("daño");
        }
           
        if (otherCollider.gameObject.CompareTag("Player"))
        {
            bvJugador.vidaActual -= dañoJugador;
            Debug.Log("auch");
        }
    }
}
