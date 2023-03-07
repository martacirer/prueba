using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{


    public Barra_Vida bvJugador;
    public Barra_Vida bvEnemigo;
    

    public float da�oAlEnemigo = 10f;
    public float da�oAlJugador = 15f;
    

    public ParticleSystem explosionParticleSystem;

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
            bvEnemigo.vidaActual -= da�oAlEnemigo;// baja vida al enemigo
            Debug.Log("da�o");

            Instantiate(explosionParticleSystem,
                    transform.position,
                explosionParticleSystem.transform.rotation);// particulas

                explosionParticleSystem.Play();
        }
           
        
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Player"))
        {
            bvJugador.vidaActual -= da�oAlJugador;//baja vida al player
            Debug.Log("auch");

           
        }   

    }
}
