using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{


    public Barra_Vida bvJugador;
    public Barra_Vida bvEnemigo;
    

    public float dañoAlEnemigo = 10f;
    public float dañoAlJugador = 15f;
    

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
            bvEnemigo.vidaActual -= dañoAlEnemigo;// enemy low life
            Debug.Log("daño");

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
            bvJugador.vidaActual -= dañoAlJugador;//player low life
            Debug.Log("auch");
        }   

    }
}
