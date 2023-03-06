using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{


    public Barra_Vida bvJugador;
    public Barra_Vida bvEnemigo;
    

    public float da�oEnemigo = 10f;
    public float da�oJugador = 15f;
    

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
            bvEnemigo.vidaActual -= da�oEnemigo;// baja vida al enemigo
            Debug.Log("da�o");
        }
           
        if (otherCollider.gameObject.CompareTag("Player"))
        {
            bvJugador.vidaActual -= da�oJugador;
            Debug.Log("auch");
        }
    }
}
