using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
    {
         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");

         transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
         transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

         if(Input.GetKeyDown(KeyCode.Space))
         {
             //velocity = forceJump;
             //transform.Translate(new Vector3(0, gravity * forceJump, 0) * Time.deltaTime);
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

    //activar cambio de material cunado haya cogido la gema
    public void OnTriggerStay(Collider other)
    {

        pickUp.SetActive(true);

        if(other.gameObject.CompareTag("Roc") && Epress == true)
        {
            Destroy(other.gameObject);
            PortalCircle.GetComponent<Renderer>().material = PortalMat_Activado;
            gemCollected = true;

            pickUp.SetActive(false);
        }
    }
    
    

    private void OnTriggerEnter (Collider otherCollider)
    {

        //cambiar de escena si has cogido la gema y tocas el portal
        if (otherCollider.gameObject.CompareTag("Portal") && gemCollected == true)
        {
           
            Debug.Log("nivel 1 completado");
            SceneManager.LoadScene("LevelPassed");
        }
         
        
       
    }
    
}
