using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PLayerController : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    public float speed = 15f;
    
    public bool Epress = false;
    private bool gemCollected = false;
   
    private Rigidbody playerRigidbody;

    public float forceJump;
    public GameObject PortalCircle;
    public Material PortalMat_Activado;
    //float velocity;
    
    public GameObject pickUp;

    public GameObject Portal;
    public GameObject Gem;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;

       Physics.gravity *= 1;

       pickUp.SetActive(false);
    }

    void Update()
    {//mov player
         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");

         transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
         transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

         if(Input.GetKeyDown(KeyCode.Space))
         {
             
             playerRigidbody.AddForce(Vector3.up * forceJump, ForceMode.Impulse);
             
         }
        
         
         if(Input.GetKeyDown(KeyCode.LeftShift))
         {
            speed *= 2;
         }

           
         if(Input.GetKeyUp(KeyCode.LeftShift))
         {
            speed /= 2;
         }

         if(Input.GetKeyDown(KeyCode.E))
         {
              Epress = true;
         }
         if(Input.GetKeyUp(KeyCode.E))
         {
              Epress = false;
         }
          

         
    }

    //active the material when catch the gem
    public void OnTriggerStay(Collider other)
    {

        pickUp.SetActive(true);

        if(other.gameObject.CompareTag("Roc") && Epress == true)
        {
            Destroy(other.gameObject);
            PortalCircle.GetComponent<Renderer>().material = PortalMat_Activado;
            gemCollected = true;

            pickUp.SetActive(false);

            Gem.SetActive(false);
            Portal.SetActive(true);
            
        }
    }
    
    

    private void OnTriggerEnter (Collider otherCollider)
    {

        //change the scene when touch the portal
        if (otherCollider.gameObject.CompareTag("Portal") && gemCollected == true)
        {
           
            
            SceneManager.LoadScene("LevelPassed");
        }
         
        
       
    }
    
}
