using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Destroy(otherCollider.gameObject);//Destroy object when collide
            bvEnemigo.vidaActual -= da�oAlEnemigo;// enemy low life
            Debug.Log("da�o");

            Instantiate(explosionParticleSystem,
                    transform.position,
                explosionParticleSystem.transform.rotation);// particles

                explosionParticleSystem.Play();
        }
           
        
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Player"))
        {
            bvJugador.vidaActual -= da�oAlJugador;//player low life
            Debug.Log("auch");
        }   

    }
}
